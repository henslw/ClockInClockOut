﻿namespace ClockInClockOut.Data
{
    public interface IRecordServices
    {
        List<Record> Records { get; set; }
        Task LoadRecord();
        Task<Record> GetRecord(int IdNumber);
        Task CreateRecord(Record Record);
        Task UpdateRecord(Record Record, int IdNumber);
        Task DeleteRecord(int IdNumber);
    }
}
