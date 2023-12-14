using System.Threading.Channels;
using FactoryMethod;

Creator creator = new CreatorLevel1();
var level1 = creator.Create();
Console.WriteLine(level1.Name);

creator = new CreatorLevel2();
var level = creator.Create();
Console.WriteLine(level.Name);