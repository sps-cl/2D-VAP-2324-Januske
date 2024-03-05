const{Person} = require("./person");
const express = require('express');
const path = require('path');
const app = express();
app.use(express.static(__dirname));
app.use(express.urlencoded({extended: true}));
app.get("/", (req, res) => {
    res.sendFile(path.join(__dirname, "index.html"));
})
app.get('/', (req, res) => {
    res.sendFile(__dirname + '/index.html');
  });
  
  app.get('/random-person', (req, res) => {
    const randomPerson = new Person(
      getRandomName(),
      getRandomSurname(),
      generateRandomId()
    );
  
    res.json(randomPerson);
  });
  
  function getRandomName() {
    const name = ["David", "Petr", "Václav", "Martin", "Zdeněk", "Daniel", "Benjamin", ];
    return name[Math.floor(Math.random() * name.length)];
  }
  
  function getRandomSurname() {
      const surmane = ["Poupa", "Šupola", "Chudoba", "Masopust", "Pažout", "Kreisinger"];
      return surmane[Math.floor(Math.random() * surmane.length)];
    }
  
  function generateRandomId() {
    return Math.floor(Math.random() * 1000);
  }

app.listen(7707);