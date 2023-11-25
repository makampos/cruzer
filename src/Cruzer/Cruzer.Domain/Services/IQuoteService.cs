using Cruzer.Domain.Models.Context;
using Cruzer.Domain.Models.Entitites;

namespace Cruzer.Domain.Services
{
    internal interface IQuoteService
    {
        RepairShopContext Context { get; init; }
        Quote? GenerateQuote(int repairOrderId);
    }
}