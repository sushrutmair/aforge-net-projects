# aforge-net-projects
Projects utilizing the Aforge.NET framework and written in .NET C#.

This repository includes some pretty old projects that I had made about ~2009 using the excellent AForge.NET framework. It seems that the framework is not actively being maintained any longer but its details are available at http://www.aforgenet.com/.

The projects should run on any Windows 7+ system with the latest .NET framework. As against normal practive, I've retained the built binaries (both debug + release) for all these projects in their /bin folder. This is to allow folks to run those programs without having to first build them. Another warning: the projects require Visual Studo 2010+ to explore and build. Express versions should work. I have not tried on IDE's later than VS 2010 - the last I built these was years back!

I have put these up here only for interested people who would like to learn about computer vision in an approachable manner, especially those that are comfortable with Windows programming and C# on .NET. Note that there are equally good (or better) framework's available now (as of writing this in 2018).

A brief about the projects:
 - Splash: Is essentially a primitive electronic whiteboard support drawing with 3 colors - Red, Blue and Green. This was made for my then almost 2 yr old. Splash utilizes any attached (or inbuilt) camera on your PC and detects a particular shade of red (a whiteboard marker's red cap should do) and draws the detected blob on the whiteboard. The idea was to have the kid wear the cap on his finger and draw simple shapes. Spalsh can also connect to an Arduino based board to mimic the colors being drawn on LED's.
Note - Splash's drawing is not very smooth - it is flicker prone. While the kide did enjoy it as only a toddler can, it needs work. I abandoned it as my day job got increasingly demanding.

- Magic Wand: Similar in concept to Splash. Here the same color filtering principle was used (except you can select the color you want to filter). The main screen has a grid panel and you can attach an image and sound file to each grid tile per you choosing. For e.g. an apple image with 'an apple a day...' rhyme. As is evident now, this was also for my son to play with. His goal was to use the whiteboard marker to move an icon to the right image he'd been told to and he would be rewarded by the nursery rhyme playing.
