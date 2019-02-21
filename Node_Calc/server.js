const express = require("express");
const cors = require("cors");
const app = express();
app.use(cors());

var server=app.listen(8000,"localhost", function()  {
    var host=server.address().address;
    var port=server.address().port;
    console.log("Server listening at http://%s:%s", host, port);
});

app.get("/add", (request, response) => {
    response.status(200).send(parseInt(request.query.value1) + parseInt(request.query.value2)+"");
})

app.get("/sub", (request, response) => {
    response.status(200).send(parseInt(request.query.value1) - parseInt(request.query.value2)+"");
})

app.get("/mul", (request, response) => {
    response.status(200).send(parseInt(request.query.value1) * parseInt(request.query.value2)+"");
})

app.get("/div", (request, response) => {
    response.status(200).send(parseInt(request.query.value1) / parseInt(request.query.value2)+"");
})
