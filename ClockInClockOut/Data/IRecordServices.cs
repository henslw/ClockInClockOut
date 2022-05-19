namespace ClockInClockOut.Data
{
    public interface IRecordServices
    {
        List<Record> Records { get; set; }
        Task LoadRecord();
        Task<Record> GetRecord(int ItemNumber);
        Task CreateRecord(Record Record);

        // for clockin create record
        Task CreateRecord2(Record Record);

        Task UpdateRecord(Record Record, int ItemNumber);

        // for clock in/out update record
        Task UpdateRecord2(Record Record, int ItemNumber);

        Task DeleteRecord(int ItemNumber);
    }
}
