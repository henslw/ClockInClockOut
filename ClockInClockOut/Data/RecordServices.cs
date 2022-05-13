using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
namespace ClockInClockOut.Data
{


        public class RecordServices : IRecordServices
        {

            private readonly DataContext _context;
            private readonly NavigationManager _navigationManager;

            public RecordServices(DataContext context, NavigationManager navigationManager)
            {

                _context = context;
                _navigationManager = navigationManager;
                _context.Database.EnsureCreated();
            }
            public List<Record> Records { get; set; } = new List<Record>();

            public async Task CreateRecord(Record record)
            {
                _context.Records.Add(record);
                await _context.SaveChangesAsync();
                _navigationManager.NavigateTo("Records");
            }
            // used for clock in to create record
            public async Task CreateRecord2(Record record)
            {
                _context.Records.Add(record);
                await _context.SaveChangesAsync();
            }


        public async Task DeleteRecord(int ItemNumber)
            {
                var record = await _context.Records.FindAsync(ItemNumber);
                if (record == null)
                    throw new Exception("Record not found.");

                _context.Records.Remove(record);
                await _context.SaveChangesAsync();
                _navigationManager.NavigateTo("Records");
            }

            public async Task<Record> GetRecord(int ItemNumber)
            {
                var record = await _context.Records.FindAsync(ItemNumber);
                if (record == null)
                    throw new Exception("record not found.");
                return record;
            }

            public async Task LoadRecord()
            {
            Records = await _context.Records.ToListAsync();
            }

            public async Task UpdateRecord(Record record, int ItemNumber)
            {
                var dbRecord = await _context.Records.FindAsync(ItemNumber);
                if (dbRecord == null)
                    throw new Exception("Record not found.");
            dbRecord.IdNumber = record.IdNumber;
            dbRecord.EmployeeName=record.EmployeeName;
            dbRecord.ClockInTime = record.ClockInTime;
            dbRecord.ClockOutTime = record.ClockOutTime;
            dbRecord.TotalHoursWorked = record.TotalHoursWorked;

                await _context.SaveChangesAsync();
                _navigationManager.NavigateTo("Records");
            }

            public async Task UpdateRecord2(Record record, int ItemNumber)
            {
                var dbRecord = await _context.Records.FindAsync(ItemNumber);
                if (dbRecord == null)
                    throw new Exception("Record not found.");
                dbRecord.IdNumber = record.IdNumber;
                dbRecord.EmployeeName = record.EmployeeName;
                dbRecord.ClockInTime = record.ClockInTime;
                dbRecord.ClockOutTime = record.ClockOutTime;
                dbRecord.TotalHoursWorked = record.TotalHoursWorked;

                await _context.SaveChangesAsync();

            }
        }   
    }



