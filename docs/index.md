<html>
<body>
test1
</body>
    <script src="/TemplateData/UnityProgress.js"></script>  
    <script src="/Build/UnityLoader.js"></script>
    <script>
    var gameInstance = UnityLoader.instantiate("gameContainer", "/Build/builds.json",{onProgress: UnityProgress});  
    </script>
    <div class="webgl-content">
    <div id="gameContainer" style="width: 960px; height: 600px"></div>
    </div>

<body>
test2
</body>
    <script src="/docs/TemplateData/UnityProgress.js"></script>  
    <script src="/docs/Build/UnityLoader.js"></script>
    <script>
    var gameInstance = UnityLoader.instantiate("gameContainer", "/docs/Build/builds.json",{onProgress: UnityProgress});  
    </script>
    <div class="webgl-content">
    <div id="gameContainer" style="width: 960px; height: 600px"></div>
    </div>
</html>