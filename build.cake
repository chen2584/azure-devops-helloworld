var projectFile = @"src\SocWebApi\SocWebApi.csproj";

Task("Publish").Does(() =>{
  var publishPath = ".publish";

  DotNetCoreClean(projectFile);
  CleanDirectory(publishPath);
    
  DotNetCorePublish(projectFile, new DotNetCorePublishSettings {
    OutputDirectory = publishPath
  });
});

var target = Argument("target", "Publish");
RunTarget(target);