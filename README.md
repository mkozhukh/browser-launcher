browser-launcher
================

Translates file paths to http urls, so you can open http files with valid urls instead of file://protocol.


### How to use


- shift+right click on html (php or any other web format) file
- select "Open with" command
- select BrowserLauncher as default program for this file type
- go to webserver root and create there ".webroot" file, with http address of server ( check .webroot.sample in the project ). 

That is it! Now you can open any file through explorer ( or total command, or any other program) and it will be opened in browser by valid http url, instead of ugly file:// protocol. 

You can have different .webroot files for different folders, so files from each folder can be configured to different web servers. 

