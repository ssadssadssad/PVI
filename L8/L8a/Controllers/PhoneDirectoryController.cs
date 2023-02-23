using L8a.Models;
using L8a.Sql;
using Microsoft.AspNetCore.Mvc;

namespace L8a.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PhoneDirectoryController : ControllerBase
{
    private readonly ILogger<PhoneDirectoryController> _logger;
    private readonly SqlPhoneDirectoryRepository _phoneDirectoryRepository;

    public PhoneDirectoryController(ILogger<PhoneDirectoryController> logger,
        SqlPhoneDirectoryRepository phoneDirectoryRepository)
    {
        _logger = logger;
        _phoneDirectoryRepository = phoneDirectoryRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<PhoneDirectoryRecord>> GetAll() =>
        await _phoneDirectoryRepository.GetPhoneDirectoryListAsync();

    [HttpGet("{guid:guid}")]
    public async Task<PhoneDirectoryRecord> Get(Guid guid) =>
        (await _phoneDirectoryRepository.GetPhoneDirectoryListAsync()).FirstOrDefault(record => record.Id == guid) ??
        new PhoneDirectoryRecord();

    [HttpPost]
    public async Task<PhoneDirectoryRecord> Post([FromBody] PhoneDirectoryRecord value)
    {
        await _phoneDirectoryRepository.CreateAsync(value);
        await _phoneDirectoryRepository.SaveAsync();
        return value;
    }

    [HttpPut("{guid:guid}")]
    public async Task<PhoneDirectoryRecord> Put(Guid guid, [FromBody] PhoneDirectoryRecord value)
    {
        value.Id = guid;
        await _phoneDirectoryRepository.UpdateAsync(value);
        await _phoneDirectoryRepository.SaveAsync();
        return value;
    }

    [HttpDelete("{guid:guid}")]
    public async Task<PhoneDirectoryRecord> Delete(Guid guid)
    {
        var deletedRecord = await Get(guid);
        await _phoneDirectoryRepository.DeleteAsync(deletedRecord);
        await _phoneDirectoryRepository.SaveAsync();
        return deletedRecord;
    }
}