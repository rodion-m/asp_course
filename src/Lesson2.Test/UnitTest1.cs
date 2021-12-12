using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using Lesson2.Demo;
using Xunit;
using Xunit.Abstractions;

namespace Lesson2.Test;

public class UnitTest1
{
    private readonly ITestOutputHelper _output;
    
    public UnitTest1(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void Parallel_list_demo()
    {
        List<float> values = new();
        Parallel.For(0, 1000, i =>
        {
            values.Add(i);
            _output.WriteLine(values.Count.ToString());
        });

        values.Should().HaveCount(1000);
    }
    
    [Fact]
    public void Float_price_demo()
    {
        float price = 0f;
        for (int i = 0; i < 1_000_000; i++)
        {
            price += 0.01f;
        }
        
        price.Should().Be(10_000f);
    }
    
    [Fact]
    public void Double_price_demo()
    {
        double price = 0d;
        for (int i = 0; i < 1_000_000; i++)
        {
            price += 0.01;
        }

        price = price * 100_000d;
        
        price.Should().Be(1_000_000_000d);
    }
    
    
    
    
    
    [Fact]
    public void Decimal_price_demo()
    {
        decimal price = 0m;
        for (int i = 0; i < 1_000_000; i++)
        {
            price += 0.01m;
        }

        price = price * 100_000m;
        
        price.Should().Be(1_000_000_000m);
    }
 
    [Fact]
    public void Decimal_price_demo2()
    {
        var price = 1m;
        var pDiv3 = price / 3;
        var priceSummed = pDiv3 + pDiv3 + pDiv3;
        price.Should().Be(priceSummed);
    }
    
    [Fact]
    public void Decimal_price_demo3()
    {
        var price = 1m;
        for (int i = 0; i < 95; i++)
        {
            price *= 2m;
        }

        var priceInc = price + 0.1m;
        price.Should().Be(priceInc);
    }
}