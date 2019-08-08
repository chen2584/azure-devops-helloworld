Task("Default").Does(() =>
{
  Information("Hello World!");
});

var target = Argument("target", "Default");
RunTarget(target);