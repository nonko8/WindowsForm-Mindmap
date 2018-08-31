using System;
using System.Drawing;
using System.Windows.Forms;
using SimpleMindmapForm.Controllers;

namespace SimpleMindmapForm
{
    public partial class SimpleMaindmapForm : Form
    {
        private NodeController rootNode = new NodeController(
                                                NodeController.NodeX, NodeController.NodeY,
                                                NodeController.NodeWidth, NodeController.NodeHeight
                                              );
        private NodeController selectedNode = null;

        public SimpleMaindmapForm()
        {
            InitializeComponent();

            pictureBox.Image = new Bitmap(pictureBox.ClientRectangle.Width, pictureBox.ClientRectangle.Height);
            selectedNode = rootNode;
            Draw(rootNode);
        }

        private void Draw(NodeController node, bool isRecursion = false)
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

                if (!isRecursion)
                {
                    g.Clear(Color.White);
                }

                var nodeRectangle = new Rectangle(node.X, node.Y, NodeController.NodeWidth, NodeController.NodeHeight);

                g.FillEllipse(brush, nodeRectangle);
                g.DrawEllipse(pen, nodeRectangle);
                if (node.Parent != null)
                {
                    g.DrawLine(pBlack, node.Parent.EndPoint(), node.StartPoint());
                }
                g.DrawString(node.Text, font, bBlack, node.TextPoint(TextRenderer.MeasureText(g, node.Text, font)));

                foreach (var n in node.Children)
                {   
                    Draw(n, true);
                }
            }

            pictureBox.Invalidate();
        }

        private void AddNodeButton_Click(object sender, EventArgs e)
        {
            if (selectedNode != null)
            {
                selectedNode.Add();
                Draw(rootNode);
            }
        }

        private void DeleteNodeButton_Click(object sender, EventArgs e)
        {
            if (selectedNode?.Parent != null)
            {
                selectedNode.Remove(selectedNode);
                selectedNode = rootNode;
                Draw(rootNode);
            }
        }

        private void EditNodeText_TextChanged(object sender, EventArgs e)
        {
            if (selectedNode != null)
            {
                selectedNode.Text = editNodeText.Text;
            }
            Draw(rootNode);
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            selectedNode = rootNode.GetPosition(e.X, e.Y);
            if (selectedNode == null)
            {
                editNodeText.Text = "";
                return;
            }
            editNodeText.Text = selectedNode.Text;
            Draw(rootNode);
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedNode == null || rootNode.GetPosition(e.X, e.Y) == selectedNode)
            {
                return;
            }

            selectedNode.X = e.X;
            selectedNode.Y = e.Y;
            Draw(rootNode);
        }
    }
}
