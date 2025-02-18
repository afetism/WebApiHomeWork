using System.Collections.Concurrent;

namespace FirstApiProject.Persistence.MiddlewareServices;

public  class RateLimitService(int maxRequest, TimeSpan timeout)
{
    private readonly ConcurrentDictionary<string, List<DateTime>> _requests = new();
    private readonly int _maxRequest = maxRequest;
    private readonly TimeSpan _timeout = timeout;


    public bool IsAllowedRequest(string key)
    {
        var now= DateTime.UtcNow;

        if (!_requests.ContainsKey(key))
        {
            _requests[key] = new List<DateTime> { new() };
            return true;
        }

        _requests[key]=_requests[key].Where(t=>t-now < _timeout).ToList();
        if (_requests[key].Count >_maxRequest)
            return false;

        _requests[key].Add(now);
        return true;


    }
}
