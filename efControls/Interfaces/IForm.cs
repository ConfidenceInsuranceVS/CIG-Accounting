namespace efControls
{
    internal interface IForm
    {
        bool SuperUser { get; set; }
        bool AllowAdd { get; set; }
        bool AllowEdit { get; set; }
        bool AllowDelete { get; set; }
        bool AllowPrint { get; set; }
        bool AllowPost { get; set; }
        bool DenyAccess { get; set; }
    }
}
