using System;
using System.Collections.Generic;
using ds.test.impl;
using Xunit;

namespace TestAdvanta
{
    public class Tests
    {
        [Theory]
        [InlineData("Addition", typeof(AdditionPlugin))]
        [InlineData("Division", typeof(DivisionPlugin))]
        [InlineData("Multiplication", typeof(MultiplicationPlugin))]
        [InlineData("Subtraction", typeof(SubtractionPlugin))]
        public void GetPlugin_Test(string pluginName, Type expectedType)
        {
            IPlugin actualPlugin = Plugins.GetPlugin(pluginName);
            Assert.NotNull(actualPlugin);
            Assert.IsType(expectedType, actualPlugin);
        }
        
       
        
        [Fact]
        public void PluginsCount_Test()
        {
            Assert.Equal(4, Plugins.PluginsCount);
        }
        
        [Fact]
        public void GetPluginNames_Test()
        {
            IEnumerable<string> pluginNames =  Plugins.GetPluginNames;
            Assert.Contains("Subtraction", pluginNames);
            Assert.Contains("Multiplication", pluginNames);
            Assert.Contains("Division", pluginNames);
            Assert.Contains("Addition", pluginNames);
        }
        
        
    }
}