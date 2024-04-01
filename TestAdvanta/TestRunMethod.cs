using System;
using ds.test.impl;
using Xunit;

namespace TestAdvanta
{
    public class TestRunMethod
    {
        [Theory]
        [InlineData("Addition")]
        public void Addition_Run_MethodPlugin_Test(string pluginName)
        {
            IPlugin actualPlugin = Plugins.GetPlugin(pluginName);
            Assert.NotNull(actualPlugin);
            Assert.Equal(12, actualPlugin.Run(10, 2));
        }
        
        [Theory]
        [InlineData("Division")]
        public void Division_Run_MethodPlugin_Test(string pluginName)
        {
            IPlugin actualPlugin = Plugins.GetPlugin(pluginName);
            Assert.NotNull(actualPlugin);
            Assert.Equal(0, actualPlugin.Run(2, 10));
        }

        [Theory]
        [InlineData("Division")]
        public void DivisionOnZero_Run_MethodPlugin_Test(string pluginName)
        {
            IPlugin actualPlugin = Plugins.GetPlugin(pluginName);
            Assert.NotNull(actualPlugin);
            Assert.ThrowsAny<DivideByZeroException>(() => actualPlugin.Run(5, 0));
        }
        
        [Theory]
        [InlineData("Multiplication")]
        public void Multiplication_Run_MethodPlugin_Test(string pluginName)
        {
            IPlugin actualPlugin = Plugins.GetPlugin(pluginName);
            Assert.NotNull(actualPlugin);
            Assert.Equal(6, actualPlugin.Run(3, 2));
        }
        
        [Theory]
        [InlineData("Subtraction")]
        public void Subtraction_Run_MethodPlugin_Test(string pluginName)
        {
            IPlugin actualPlugin = Plugins.GetPlugin(pluginName);
            Assert.NotNull(actualPlugin);
            Assert.Equal(-3, actualPlugin.Run(2, 5));
        }
    }
}