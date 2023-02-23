using L8a.Models;
using Microsoft.EntityFrameworkCore;

namespace L8a.Sql;

public class SqlPhoneDirectoryRepository
{
    private readonly PhoneDirectoryContext _context;
    private bool _disposed;

    public SqlPhoneDirectoryRepository(PhoneDirectoryContext context) => _context = context;

    public async void Dispose()
    {
        await SaveAsync();
        if (!_disposed) await _context.DisposeAsync();
        _disposed = true;
        GC.SuppressFinalize(this);
    }

    public async Task<IEnumerable<PhoneDirectoryRecord>> GetPhoneDirectoryListAsync() =>
        await _context.PhoneDirectory.OrderBy(record => record.Name).ToListAsync();

    public Task CreateAsync(PhoneDirectoryRecord phoneDirectoryRecord) =>
        Task.Run(() => _context.PhoneDirectory.Add(phoneDirectoryRecord));

    public async Task UpdateAsync(PhoneDirectoryRecord phoneDirectoryRecord)
    {
        var record = await _context.PhoneDirectory.FindAsync(phoneDirectoryRecord.Id);
        if (record == null) return;
        record.Name = phoneDirectoryRecord.Name;
        record.PhoneNumber = phoneDirectoryRecord.PhoneNumber;
        //Attach Присоединяет отключенную или "отсоединенную" сущность к новому контексту
        _context.PhoneDirectory.Attach(record);
        _context.Entry(record).State = EntityState.Modified;
    }

    public async Task DeleteAsync(PhoneDirectoryRecord phoneDirectoryRecord)
    {
        var record = await _context.PhoneDirectory.FindAsync(phoneDirectoryRecord.Id);
        if (record == null) return;
        _context.Entry(record).State = EntityState.Deleted;
    }

    public async Task<bool> SaveAsync()
    {
        try
        {
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            foreach (var entry in _context.ChangeTracker.Entries<PhoneDirectoryRecord>())
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                        entry.CurrentValues.SetValues(entry.OriginalValues);
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                }

            return false;
        }
    }

    public IEnumerable<PhoneDirectoryRecord> GetPhoneDirectoryList()
    {
        return _context.PhoneDirectory.OrderBy(record => record.Name).ToList();
    }

    public void Create(PhoneDirectoryRecord phoneDirectoryRecord)
    {
        _context.PhoneDirectory.Add(phoneDirectoryRecord);
    }

    public void Update(PhoneDirectoryRecord phoneDirectoryRecord)
    {
        var record = _context.PhoneDirectory.Find(phoneDirectoryRecord.Id);
        if (record == null) return;
        record.Name = phoneDirectoryRecord.Name;
        record.PhoneNumber = phoneDirectoryRecord.PhoneNumber;
        _context.PhoneDirectory.Attach(record);
        _context.Entry(record).State = EntityState.Modified;
    }

    public void Delete(PhoneDirectoryRecord phoneDirectoryRecord)
    {
        var record = _context.PhoneDirectory.Find(phoneDirectoryRecord.Id);
        if (record == null) return;
        _context.Entry(record).State = EntityState.Deleted;
    }

    public bool Save()
    {
        try
        {
            _context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            foreach (var entry in _context.ChangeTracker.Entries<PhoneDirectoryRecord>())
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                        entry.CurrentValues.SetValues(entry.OriginalValues);
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                }

            return false;
        }
    }
}