namespace efControls
{
    public class Enums
    {
        public enum UserInfo { Created, Modified };
        public enum DataType
        {
            Parent,
            ParentChild,
            ParentChildExtension
        };
        public enum State
        {
            Delete,
            Edit,
            Empty,
            New,
            Rename,
            None,
            Off
        };

        public enum ControlState
        {
            AlwaysDisabled,
            AlwaysEnabled,
            Default,
            EditDisabled
        };

        public enum ValueType
        {
            Boolean,
            Integer
        };

        public enum toolbarButtonState
        {
            Disabled,
            Enabled,
            Hidden
        };

        public enum DisplayType
        {
            Default,
            LongDate,
            Numeric,
            Integer,
            ShortDate,
            Time,
            TitleCase
        };
        public enum AlertType
        {
            None,
            Critical,
            Warning,
            Information,
            Help
        }
    }
}
