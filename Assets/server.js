// If you are using Node.js as your web server, you should first install Express by running:
//
// > npm install express
//
// You can then start your web server by running this file:
//
// > node server.js
//
// If you can't run Node or Express, just use a simple Python server
//    
//  > python -m SimpleHTTPServer 8080
//
// Then you can navigate to http://localhost:8080 in your web browser to see the demo running.
/*
var path = require('path');

var fs = require("fs");

// Helper to get the major version of Express
function getVersion(){
  // Since Express 3.3 version is not exposed any longer
  var version = (express.version || '4.').match(/^(\d)+\./)[1];
  return Number(version);
}

var express = require('express');

var app;

var version = getVersion();

// Depending on the version number there are several ways to create an app
if(version === 2){
  app = express.createServer();
} else if(version > 2){
  app = express();
}*/
var fs = require('fs');
var count = 0;
const express = require('express');
const bodyParser = require('body-parser');
const app = express();
const port = 3000;
app.use(express.static('./'));
app.use(bodyParser.json());
app.post('/data', function(req, res){
    console.log('body: ',  req.body);
    var dictstring = JSON.stringify(req.body);
    //fs.writeFile("data.json", dictstring);
    fs.writeFile("./data.json", dictstring, err => {
        if (err) {
            console.log("Error writing file", err)
        } else {
            console.log("Successfully wrote file")
        }
    });
    //res.send(req.body);
});
app.listen(port);
/*
app.use('/', express["static"].apply(null, [__dirname + '/']));

app.get('/', function (req, res) {
  //res.sendFile(path.join(__dirname, 'index.html'));
  res.send({ "hello": 'world' });
});
let http = require('http').Server(app);
http.listen(8080);

console.log('Server running. Browse to http://localhost:8080');*/


//var webSocket = WebSocket("ws://localhost:8080");
//var http = require('http').createServer(app);
//var app = express();
//let http = require('http').Server(app);
/*app.get('/', function(req, res){
	var heartRate = document.getElementById("heart-beat").innerHTML;
	res.send("hello");
});

http.listen(3000, function(){
  console.log('listening on *:3000');
});*/