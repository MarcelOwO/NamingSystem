using System.Collections;
using NamingSystem.Core.DbContext;

namespace NamingSystem.Web.Interfaces;

public interface IApiService
{
    Task<List<NameIdea>> Ideas;
}