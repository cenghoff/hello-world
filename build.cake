var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  Information("Hello New World!");
});

RunTarget(target);
