using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMindmapForm.Controllers
{
    class NodeController
    {
        private const int NodeX = 10;
        private const int NodeY = 10;
        public NodeController(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        protected NodeController() { }

        public string Text { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Dictionary<string, string> Attribute { get; set; }

        public NodeController Parent { get; set; }
        List<NodeController> children = new List<NodeController>();
        public List<NodeController> Children
        {
            get { return children; }
            set { children = value; }
        }

        public NodeController GetRoot()
        {
            NodeController current = this;
            while (true)
            {
                if (current.Parent != null)
                {
                    current = current.Parent;
                }
                else
                {
                    break;
                }
            }
            return current;
        }

        public NodeController GetPosition(int x, int y)
        {
            if (X <= x && x <= X + Width && Y <= y && y <= Y + Height)
            {
                return this;
            }
            foreach (NodeController n in Children)
            {
                NodeController nodePosition = n.GetPosition(x, y);
                if (nodePosition != null)
                {
                    return nodePosition;
                }
            }
            return null;
        }

        public Point StartPoint()
        {
            return new Point(
                X, 
                Y + Height / 2
            );
        }

        public Point EndPoint()
        {
            return new Point(
                X + Width, 
                Y + Height / 2
            );
        }

        public Point TextPoint(Size size)
        {
            return new Point(
                X + Width / 2 - size.Width / 2,
                Y + Height / 2 - size.Height / 2
            );
        }

        public NodeController Add()
        {
            int addNodeX = X + Width + NodeX;
            int addNodeY = Y;
            foreach (var n in children)
            {
                addNodeY = Math.Max(addNodeY, n.Y + n.Height + NodeY);
            }
            NodeController node = new NodeController(addNodeX, addNodeY, Width, Height)
            {
                Parent = this
            };
            Children.Add(node);
            return node;
        }

        public NodeController Add(NodeController node)
        {
            node = node.GetRoot();
            Children.Add(node);
            node.Parent = this;
            return node;
        }

        public NodeController Adds(params NodeController[] nodes)
        {
            foreach (var item in nodes)
            {
                Add(item);
            }
            return this;
        }

        public NodeController Adds(IEnumerable<NodeController> nodes)
        {
            foreach (var item in nodes)
            {
                Add(item);
            }
            return this;
        }

        public NodeController Remove(NodeController node)
        {
            //node = node.GetRoot();
            node.Parent.Children.Remove(node);
            node.Parent = this;
            return node;
        }
    }
}
