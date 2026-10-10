<h1 align="center">Tool & Plugins Lab 7 Reflection</h1>
<p align="center">
  <i>By Summer Smith and Chandler Guzman.</i>
  <br><br>
  <img src="Execution Times.png">
  <br><br>
  <b>NOTE:</b><br>
  In the above screenshot and in the files, the native and managed plugins are incorrectly named; ManagedPluginLa.dll is the native plugin, whereas NativePluginLabCSharp is the managed plugin.
  Below is a chart with the correctly-named times shown in the screenshot above.
</p>
<br>

<div align="center"> 
   <table align="center">
    <thead align="center">
      <tr>
        <th>Plugin</th>
        <th>Time (in Ticks)</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><code>Engine</code></td>
        <td align="center">8,601</td>
      </tr>
      <tr>
        <td><code>Native</code></td>
        <td align="center">4,191</td>
      </tr>
      <tr>
        <td><code>Managed</code></td>
        <td align="center">3,239</td>
      </tr>
    </tbody>
  </table>
</div>

<br>
<div align="center"> 
  Strangely enough, the native C++ plugin was not faster than the managed C# plugin (4,191 vs. 3,239). 
  <br>
  We expected, just as was said in the lab assignment description, that the C++ plugin would be noticeably faster due to the fact that C++ is a lower-level language compared to C#.
  <br><br>
  Unlike C#, memory management in C++ (and their parent language, C) is manual. Object-oriented languages such as C# often have "garbage collection" built-in, which offers convenience in exchange for a performance cost. 
  <br> <br>
  Going into this lab, we had minimal knowledge of C++ mostly from using Unreal Engine 5. Based on our knowledge of working with C++ in Unreal Engine, we knew that there would be some interesting differences in the native and managed plugins. We enjoyed experimenting some more with C++ for this lab and seeing how we can use different programming languages within Unity!
</div>
