using System;
namespace SecondLectureLabs
{
    interface IDocument
    {
         string Name { get; set; }
         string Author { get; set; }
         string Theme { get; set; }
         string[] KeyWords { get; set; }
         string Path { get; set; }
    } 
    class Document:IDocument
    {
        private string _name;
        private string _path;
        private string[] _keyWords;
        public virtual string Name 
        {
            get
            {
                if (string.IsNullOrEmpty(_name)) return "NewDocument";
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public virtual string Author
        {
            get;
            set;
        }
        public virtual string Theme
        {
            get;
            set;
        }
        public virtual string[] KeyWords
        {
            get
            {
                if (_keyWords != null && _keyWords.Length != 0) return _keyWords;
                return new string[]{"Document"};
            }
            set
            {
                _keyWords = value;
            }
        }
        public virtual string Path
        {
            get
            {
                return _path;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + _name + ".";
                else _path = value;
            }
        }
        
    }

    class MicrosoftWordDocument : Document
    {
        private string[] _keyWords;
        private string _path;
        private string _name;
        public override string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name)) return "NewMSWordDocument";
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public override string[] KeyWords
        {
            get
            {
                if (_keyWords != null && _keyWords.Length != 0) return _keyWords;
                return new string[]{"MicrosoftWordDocument"};
            }
            set
            {
                _keyWords = value;
            }
        }
        public override string Path
        {
            get
            {
                return _path;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + _name + ".doc";
                else _path = value;
            }
        }
    }

    class PDFDocument : Document
    {
        private string[] _keyWords;
        private string _path;
        private string _name;
        public override string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name)) return "NewPDFDocument";
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public override string[] KeyWords
        {
            get
            {
                if (_keyWords != null && _keyWords.Length != 0) return _keyWords;
                return new string[] { "PDFDocument" };
            }
            set
            {
                _keyWords = value;
            }
        }
        public override string Path
        {
            get
            {
                return _path;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + _name + ".pdf";
                else _path = value;
            }
        }
    }

    class TxtDocument : Document
    {
        private string[] _keyWords;
        private string _path;
        private string _name;
        public override string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name)) return "NewTXTDocument";
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public override string[] KeyWords
        {
            get
            {
                if (_keyWords != null && _keyWords.Length != 0) return _keyWords;
                return new string[] { "TxtDocument" };
            }
            set
            {
                _keyWords = value;
            }
        }
        public override string Path
        {
            get
            {
                return _path;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + _name + ".txt";
                else _path = value;
            }
        }
    }

    class HTMLDocument : Document
    {
        private string[] _keyWords;
        private string _path;
        private string _name;
        public override string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name)) return "NewHTMLDocument";
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public override string[] KeyWords
        {
            get
            {
                if (_keyWords != null && _keyWords.Length != 0) return _keyWords;
                return new string[] { "HTMLDocument" };
            }
            set
            {
                _keyWords = value;
            }
        }
        public override string Path
        {
            get
            {
                return _path;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + _name + ".html";
                else _path = value;
            }
        }
    }
}
