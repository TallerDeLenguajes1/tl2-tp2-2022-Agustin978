using NLog;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//var config = new NLog.Config.LoggingConfiguration();
NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

logger.Info("Goodbye cruel world!!!");
logger.Debug("Fuck this code doesn't work :(");