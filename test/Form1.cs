using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var scanner = tscsharp.ScannerTool.createScanner(tscsharp.ScriptTarget.ES5, false);

            scanner.setText(this.richTextBox1.Text);

            listBox1.Items.Clear();
            tscsharp.SyntaxKind kind = tscsharp.SyntaxKind.Unknown;
            do
            {
                kind = scanner.scan();

                var text = scanner.getTokenText();
                var value = scanner.getTokenValue();
                var pos = scanner.getTokenPos();
                listBox1.Items.Add("'" + text + "'='" + value + "'::" + kind);
            }
            while (kind != tscsharp.SyntaxKind.EndOfFileToken);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var scanner = tscsharp.ScannerTool.createScanner(tscsharp.ScriptTarget.ES5, true);

            scanner.setText(this.richTextBox1.Text);

            listBox1.Items.Clear();
            tscsharp.SyntaxKind kind = tscsharp.SyntaxKind.Unknown;
            do
            {
                kind = scanner.scan();

                var text = scanner.getTokenText();
                var value = scanner.getTokenValue();
                var pos = scanner.getTokenPos();
                listBox1.Items.Add("'" + text + "'='" + value + "'::" + kind);
            }
            while (kind != tscsharp.SyntaxKind.EndOfFileToken);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var node = tscsharp.AstTool.ParseFile(this.richTextBox1.Text);

            this.treeView1.Nodes.Clear();
            TreeNode tn = new TreeNode();
            FillTree(node, tn);
            this.treeView1.Nodes.Add(tn);
            this.treeView1.ExpandAll();

        }
        void FillTree(tscsharp.IAstNode node, TreeNode uinode)
        {
            uinode.Text = "(" + node.use + "=" + node.value + ")" + node.GetType().Name;
            if (node.subnodes != null)
                foreach (var s in node.subnodes)
                {
                    TreeNode subui = new TreeNode();
                    uinode.Nodes.Add(subui);
                    FillTree(s, subui);
                }
        }
    }
}
