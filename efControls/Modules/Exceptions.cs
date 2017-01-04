using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace efControls
{
    public class AppException : Exception
    {
        public AppException() { }
        public AppException(string _message)
        {
            message = _message;
            detailed = false;
        }
        public AppException(string _message, bool _detailed)
        {
            message = _message;
            detailed = _detailed;
        }
        public string message { get; set; }
        public bool detailed { get; set; }
        public override string Message
        {
            get { return string.IsNullOrEmpty(message) ? this.Message : message; }
        }
        public override string StackTrace
        {
            get { return detailed ? getErrorDetails() : this.Message; }
        }
        private string getErrorDetails()
        {
            StringBuilder sb = new StringBuilder();
            var st = new StackTrace(this, true);
            var frame = st.GetFrame(0);
            sb.AppendFormat("Error   : {0}", this.message);
            sb.Append(Environment.NewLine);
            sb.AppendFormat("Line No.: {0}", frame.GetFileLineNumber());
            sb.Append(Environment.NewLine);
            sb.AppendFormat("Method  : {0}", frame.GetMethod());
            sb.Append(Environment.NewLine);
            sb.AppendFormat("Program : {0}", frame.GetFileName());
            return sb.ToString();
        }
    }
    public class PrivilegeException : AppException
    {
        public PrivilegeException()
        {
            detailed = false;
            message = "Not Allowed To Perform The Requested Action !!";
        }
        public PrivilegeException(string _message)
        {
            detailed = false;
            message = _message;
        }
    }
    public class DeleteException : AppException
    {
        public DeleteException()
        {
            detailed = false;
            message = "Unable to delete current record [Relation] !!";
        }
        public DeleteException(string _message)
        {
            detailed = false;
            message = _message;
        }
    }
    public class InsertException : AppException
    {
        public InsertException()
        {
            detailed = false;
            message = "No records added !!";
        }
        public InsertException(string _message)
        {
            detailed = false;
            message = _message;
        }
    }
    public class UpdateException : AppException
    {
        public UpdateException()
        {
            detailed = false;
            message = "No records updated !!";
        }
        public UpdateException(string _message)
        {
            detailed = false;
            message = _message;
        }
    }
    public class RlockException : AppException
    {
        public RlockException()
        {
            detailed = false;
            message = "Record Locked By Another User !!";
        }
        public RlockException(string _message)
        {
            detailed = false;
            message = string.Format("Record Locked By {0}", _message);
        }
    }
    public class NotFoundException : AppException
    {
        public NotFoundException()
        {
            detailed = false;
            message = "Record Not Found !!";
        }
    }

}
