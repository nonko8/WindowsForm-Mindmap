using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleMindmapForm.Controllers;

namespace SimpleMindmapForm
{
    public partial class SimpleMaindmapForm : Form
    {
        private const int NodeWidth = 100;
        private const int NodeHeight = 50;
        private const int NodeX = 10;
        private const int NodeY = 10;
        private Rectangle nodeRectangle = new Rectangle(NodeX, NodeY, NodeWidth, NodeHeight);
        private NodeController rootNode = new NodeController(NodeX, NodeY, NodeWidth, NodeHeight);
        private NodeController selectedNode = null;

        public SimpleMaindmapForm()
        {
            InitializeComponent();

            selectedNode = rootNode;
            pictureBox.Image = new Bitmap(pictureBox.ClientRectangle.Width, pictureBox.ClientRectangle.Height);
            DrawNode(rootNode);
        }

        private void DrawNode(NodeController node, bool isRecursion = false)
        {
            using (var bBlack = new SolidBrush(Color.Black))
            using (var bWhite = new SolidBrush(Color.White))
            using (var bLightGray = new SolidBrush(Color.LightGray))
            using (var pBlack = new Pen(Color.Black))
            using (var pRed = new Pen(Color.Red))
            using (var font = new Font("Meiryo UI", 10))
            using (var g = Graphics.FromImage(pictureBox.Image))
            {
                var brush = bWhite;
                var pen = pBlack;

                if (selectedNode == node)
                {
                    brush = bLightGray;
                    pen = pRed;
                }

                //g = CreateGraphics();
                if (!isRecursion)
                {
                    g.Clear(Color.White);
                }
                nodeRectangle = new Rectangle(node.X, node.Y, NodeWidth, NodeHeight);
                g.FillEllipse(brush, nodeRectangle);
                g.DrawEllipse(pen, nodeRectangle);

                if (node.Parent != null)
                {
                    g.DrawLine(pBlack, node.Parent.EndPoint(), node.StartPoint());
                }

                g.DrawString(node.Text, font, bBlack, node.TextPoint(TextRenderer.MeasureText(g, node.Text, font)));
                foreach (var n in node.Children)
                {   
                    DrawNode(n, true);
                }
            }

            // PictureBoxを再描画させて画面に反映
            pictureBox.Invalidate();
        }

        private void AddNodeButton_Click(object sender, EventArgs e)
        {
            if (selectedNode != null)
            {
                selectedNode.Add();
                DrawNode(rootNode);
            }
        }

        private void DeleteNodeButton_Click(object sender, EventArgs e)
        {
            if (selectedNode != null && selectedNode.Parent != null)
            {
                selectedNode.Remove(selectedNode);
                selectedNode = null;
                DrawNode(rootNode);
            }
        }

        private void EditNodeText_TextChanged(object sender, EventArgs e)
        {
            if (selectedNode != null)
            {
                selectedNode.Text = editNodeText.Text;
            }
            DrawNode(rootNode);
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            selectedNode = rootNode.GetPosition(e.X, e.Y);
            if (selectedNode == null)
            {
                editNodeText.Text = "";
                pictureBox.Select();
                return;
            }
            editNodeText.Text = selectedNode.Text;
            DrawNode(rootNode);

            //ドラッグを開始する
            DoDragDrop(Graphics.FromImage(pictureBox.Image), DragDropEffects.All);
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
