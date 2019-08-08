var projectFile = @"src/DevopsHelloWorld/DevopsHelloWorld.csproj";
var publishPath = ".publish";

Task("Publish").Does(() =>{

  DotNetCoreClean(projectFile);
  CleanDirectory(publishPath);
    
  DotNetCorePublish(projectFile, new DotNetCorePublishSettings {
    OutputDirectory = publishPath
  });
});

Task("Publish-Zip").IsDependentOn("Publish").Does(() =>{
  var files = GetFiles(".publish/*");
  Zip("./", "publish.zip", files);
});

var target = Argument("target", "Publish-Zip");
RunTarget(target);