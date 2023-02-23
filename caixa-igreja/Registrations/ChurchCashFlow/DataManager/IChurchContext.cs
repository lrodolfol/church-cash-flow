using Microsoft.AspNetCore.Mvc;

namespace ChurchCashFlow.DataManager;
public interface IChurchContext
{
    public Task<IActionResult> GetChurches();
    public Task<IActionResult> GetChurchesWithAddress();
    public Task<IActionResult> GetChurch();
    public Task<IActionResult> PostChurch();
    public Task<IActionResult> PutChurch();
    public Task<IActionResult> DeleteChurch();
}
