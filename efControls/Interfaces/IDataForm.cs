namespace efControls
{
    internal interface IDataForm
    {
        string lockFilename();
        int getRowsCount();
        void RefreshRecord();
    }
}
