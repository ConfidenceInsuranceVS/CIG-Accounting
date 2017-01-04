namespace efControls
{
    internal interface IControl
    {
        Enums.ControlState DefaultState { get; set; }
        bool Enabled { get; set; }
        void Refresh();
    }
}
