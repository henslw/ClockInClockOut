namespace ClockInClockOut.Data
{
    public interface IRecordServices
    {
        List<Record> Records { get; set; }
        Task LoadRecord();
        Task<Record> GetRecord(int ItemNumber);
        // used in recordCRUD
        Task CreateRecord(Record Record);

        // for clockin create record
        Task CreateRecord2(Record Record);
        // used in recordCRUD

        Task UpdateRecord(Record Record, int ItemNumber);

        // for clock in/out update record
        Task UpdateRecord2(Record Record, int ItemNumber);

        // used in recordCRUD
        Task DeleteRecord(int ItemNumber);
        
        // for delete record in export/delete page
        Task DeleteRecord2(int ItemNumber);

    }
}
