using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Lesson4.Test;

public class UnitTest1
{
    [Fact]
    public void BracketsDecrement()
    {
        const int count = 10000;
        const string key = "key";
        var dict = new ConcurrentDictionary<string, int>
        {
            [key] = 10000
        };
        Parallel.For(0, count, _ =>
        {
            dict[key]--;
        });
        
        Assert.Equal(0, dict[key]);
    }
    
    [Fact]
    public void TryUpdateDecrement()
    {
        const int count = 10000;
        const string key = "key";
        
        var dict = new ConcurrentDictionary<string, int>
        {
            [key] = count
        };
        
        Parallel.For(0, count, _ =>
        {
            var value = dict[key];
            dict.TryUpdate(key, value - 1, value);
        });
        
        Assert.Equal(0, dict[key]);
    }
    
    [Fact]
    public void Cycling_removing_is_successful()
    {
        const int count = 10000;
        const string key = "key";
        var dict = new ConcurrentDictionary<string, int>
        {
            [key] = count
        };
        
        Parallel.For(0, count, _ =>
        {
            if (!dict.TryGetValue(key, out var value)) return;
            while (!dict.TryUpdate(key, value - 1, value))
            {
                if (!dict.TryGetValue(key, out value)) return;
            }
        });
        
        Assert.Equal(0, dict[key]);
    }
    
    [Fact]
    public void Removing_using_AddOrUpdateMethod_is_successful()
    {
        const int count = 10000;
        const string key = "key";
        var dict = new ConcurrentDictionary<string, int>
        {
            [key] = count
        };
        
        Parallel.For(0, count, _ =>
        {
            dict.AddOrUpdate(key, 
                _ => 0, 
                (_, value) => value - 1);
        });
        
        Assert.Equal(0, dict[key]);
    }
}