using System.Collections.Generic;

namespace tscsharp
{


    public class AstTool
    {
        public struct ScanItem
        {
            public ScanItem(SyntaxKind kind, string text, string value, int pos)
            {
                this.kind = kind;
                this.text = text;
                this.value = value;
                this.pos = pos;
            }
            public SyntaxKind kind;
            public string text;
            public string value;
            public int pos;
        }

        public static AstNodeFile ParseFile(string srctext)
        {
            List<ScanItem> items = ScanCode(srctext);

            int wordpos = 0;
            var filenode = new AstNodeFile();
            filenode.Parse(items.ToArray(), ref wordpos);
            return filenode;
        }

        static List<ScanItem> ScanCode(string srctext)
        {
            List<ScanItem> items = new List<ScanItem>();
            var scanner = tscsharp.ScannerTool.createScanner(tscsharp.ScriptTarget.ES5, false);
            scanner.setText(srctext);
            tscsharp.SyntaxKind kind = tscsharp.SyntaxKind.Unknown;
            do
            {
                kind = scanner.scan();
                var text = scanner.getTokenText();
                var value = scanner.getTokenValue();
                var pos = scanner.getTokenPos();
                //var textpos = scanner.getTextPos();
                items.Add(new ScanItem(kind, text, value, pos));
            }
            while (kind != tscsharp.SyntaxKind.EndOfFileToken);
            return items;
        }

        public static IAstNode ParseElement(string srctext)
        {
            List<ScanItem> items = ScanCode(srctext);

            int wordpos = 0;
            var node = TestAndGenNode(items.ToArray(), 0);
            node.Parse(items.ToArray(), ref wordpos);
            return node;
        }
        public static IAstNode TestAndGenNode(AstTool.ScanItem[] items, int pos)
        {
            for (var i = pos; i < items.Length; i++)
            {
                var item = items[i];
                if (item.kind == SyntaxKind.VarKeyword)//var开头的表达式,这是一个 定义表达式
                {
                    return new AstNodeDefine();
                }
                else if (item.kind == SyntaxKind.NewLineTrivia)//换行符
                {
                    return new AstNodeUnuse();
                }
                else if(item.kind== SyntaxKind.EndOfFileToken)
                {
                    return new AstNodeEof();
                }
            }
            return null;
        }
    }
    public enum AntNodeUse
    {
        None,
        Name,
        Type,
        Value,
        Element,
        Param
    }
    public interface IAstNode
    {
        AntNodeUse use
        {
            get;
            set;
        }//节点的用途，是节点的参数，片段，blabla

        string value
        {
            get;
        }
        void Parse(AstTool.ScanItem[] items, ref int pos);
        AstTool.ScanItem[] scanitems
        {
            get;
        }
        IAstNode[] subnodes
        {
            get;
        }
    }
    public class AstNodeFile : IAstNode
    {
        public AntNodeUse use
        {
            get;
            set;
        }
        public string value
        {
            get;
            private set;
        }
        public List<IAstNode> subnodesList = new List<IAstNode>();
        public IAstNode[] subnodes
        {
            get
            {
                return subnodesList.ToArray();
            }
        }
        public List<AstTool.ScanItem> scanitemsList = new List<AstTool.ScanItem>();

        public AstTool.ScanItem[] scanitems
        {
            get
            {
                return scanitemsList.ToArray();
            }
        }
        public void Parse(AstTool.ScanItem[] items, ref int pos)
        {
            int startpos = pos;

            while (pos < items.Length && pos != -1)
            {
                var type = AstTool.TestAndGenNode(items, pos);
                type.Parse(items, ref pos);
                this.subnodesList.Add(type);
            }
            int endpos = pos;
            for (var i = 0; i < endpos; i++)
            {
                this.scanitemsList.Add(items[i]);
            }
        }
    }
    public class AstNodeId : IAstNode
    {
        public AntNodeUse use
        {
            get;
            set;
        }
        public string value
        {
            get;
            private set;
        }
        public IAstNode[] subnodes
        {
            get
            {
                return null;
            }
        }
        public List<AstTool.ScanItem> scanitemsList = new List<AstTool.ScanItem>();

        public AstTool.ScanItem[] scanitems
        {
            get
            {
                return scanitemsList.ToArray();
            }
        }
        public void Parse(AstTool.ScanItem[] items, ref int pos)
        {
            var v = items[pos];
            if (v.kind == SyntaxKind.Identifier)
            {
                scanitemsList.Add(v);
                this.value = v.value;
                pos++;
            }
        }
    }
    public class AstNodeType : IAstNode
    {
        public AntNodeUse use
        {
            get;
            set;
        }
        public string value
        {
            get;
            private set;
        }

        public IAstNode[] subnodes
        {
            get
            {
                return null;
            }
        }
        public List<AstTool.ScanItem> scanitemsList = new List<AstTool.ScanItem>();

        public AstTool.ScanItem[] scanitems
        {
            get
            {
                return scanitemsList.ToArray();
            }
        }
        public void Parse(AstTool.ScanItem[] items, ref int pos)
        {
            if (items[pos].kind == SyntaxKind.NumberKeyword)
            {
                this.value = items[pos].value;
                this.scanitemsList.Add(items[pos]);
                pos++;
                return;
            }
        }
    }
    public class AstNodeValue : IAstNode
    {
        public AntNodeUse use
        {
            get;
            set;
        }
        public string value
        {
            get;
            private set;
        }

        public IAstNode[] subnodes
        {
            get
            {
                return null;
            }
        }
        public List<AstTool.ScanItem> scanitemsList = new List<AstTool.ScanItem>();

        public AstTool.ScanItem[] scanitems
        {
            get
            {
                return scanitemsList.ToArray();
            }
        }
        public void Parse(AstTool.ScanItem[] items, ref int pos)
        {
            if (items[pos].kind == SyntaxKind.FirstLiteralToken)
            {
                this.value = items[pos].value;
                this.scanitemsList.Add(items[pos]);
                pos++;
                return;
            }
        }
    }
    public class AstNodeUnuse : IAstNode
    {
        public AntNodeUse use
        {
            get;
            set;
        }
        public string value
        {
            get;
            private set;
        }

        public List<IAstNode> subnodesList = new List<IAstNode>();
        public IAstNode[] subnodes
        {
            get
            {
                return subnodesList.ToArray();
            }
        }
        public List<AstTool.ScanItem> scanitemsList = new List<AstTool.ScanItem>();

        public AstTool.ScanItem[] scanitems
        {
            get
            {
                return scanitemsList.ToArray();
            }
        }
        void IAstNode.Parse(AstTool.ScanItem[] items, ref int pos)
        {
            int startpos = pos;
            while (pos < items.Length && pos != -1)
            {
                var item = items[pos];
                if (item.kind == SyntaxKind.NewLineTrivia
                    || item.kind == SyntaxKind.WhitespaceTrivia
                    || item.kind == SyntaxKind.ConflictMarkerTrivia
                    || item.kind == SyntaxKind.SingleLineCommentTrivia
                    || item.kind == SyntaxKind.MultiLineCommentTrivia)
                {
                    pos++;
                    continue;
                }
                else
                {
                    break;
                }
            }
            int endpos = pos;
            for (var i = 0; i < endpos; i++)
            {
                this.scanitemsList.Add(items[i]);
            }
        }
    }
    public class AstNodeEof : IAstNode
    {
        public AntNodeUse use
        {
            get;
            set;
        }
        public string value
        {
            get;
            private set;
        }

        public List<IAstNode> subnodesList = new List<IAstNode>();
        public IAstNode[] subnodes
        {
            get
            {
                return subnodesList.ToArray();
            }
        }
        public List<AstTool.ScanItem> scanitemsList = new List<AstTool.ScanItem>();

        public AstTool.ScanItem[] scanitems
        {
            get
            {
                return scanitemsList.ToArray();
            }
        }
        void IAstNode.Parse(AstTool.ScanItem[] items, ref int pos)
        {
            this.scanitemsList.Add(items[pos]);
            pos++;
            return;
        }
    }
    public class AstNodeDefine : IAstNode
    {
        public AntNodeUse use
        {
            get;
            set;
        }
        public string value
        {
            get;
            private set;
        }

        public List<IAstNode> subnodesList = new List<IAstNode>();
        public IAstNode[] subnodes
        {
            get
            {
                return subnodesList.ToArray();
            }
        }
        public List<AstTool.ScanItem> scanitemsList = new List<AstTool.ScanItem>();

        public AstTool.ScanItem[] scanitems
        {
            get
            {
                return scanitemsList.ToArray();
            }
        }
        void IAstNode.Parse(AstTool.ScanItem[] items, ref int pos)
        {
            int startpos = pos;

            bool findVar = false;//找到var了
            AstNodeId name = null;//找到变量名了
            bool findColon = false;//找到冒号了
            AstNodeType type = null;//找到类型了
            bool findEqual = false;//找到等号了
            AstNodeValue value = null;//找到值了😂
            while (pos < items.Length && pos != -1)
            {
                var item = items[pos];
                if (item.kind == SyntaxKind.VarKeyword)
                {
                    findVar = true;
                    pos++;
                }
                else if (item.kind == SyntaxKind.Identifier)
                {
                    if (findVar == false)
                        throw new System.Exception("必须先有var 表达式");
                    name = new AstNodeId();
                    name.use = AntNodeUse.Name;
                    name.Parse(items, ref pos);
                }
                else if (item.kind == SyntaxKind.WhitespaceTrivia)
                {
                    //空格 donothing
                    pos++;
                }
                else if (item.kind == SyntaxKind.ColonToken)
                {//冒号
                    if (name == null)
                        throw new System.Exception("必须先有name");
                    findColon = true;
                    pos++;
                }
                else if (item.kind == SyntaxKind.NumberKeyword)
                {
                    if (findColon == false)
                        throw new System.Exception("必须先有冒号表达式");
                    type = new AstNodeType();
                    type.use = AntNodeUse.Type;
                    type.Parse(items, ref pos);
                }
                else if (item.kind == SyntaxKind.EqualsToken)
                {//等号
                    //if (type == null)
                    //    throw new System.Exception("必须先有type");
                    //不必须
                    findEqual = true;
                    pos++;
                }
                else if(item.kind== SyntaxKind.FirstLiteralToken)
                {
                    value = new AstNodeValue();
                    value.use = AntNodeUse.Value;
                    value.Parse(items, ref pos);
                }
                else
                {
                    break;
                }
            }
            name.use = AntNodeUse.Name;
            this.subnodesList.Add(name);
            if (type != null)
            {
                type.use = AntNodeUse.Type;
                this.subnodesList.Add(type);
            }
            if (value != null)
            {
                value.use = AntNodeUse.Value;
                this.subnodesList.Add(value);
            }
            int endpos = pos;
            for (var i = 0; i < endpos; i++)
            {
                this.scanitemsList.Add(items[i]);
            }

        }
    }


}
