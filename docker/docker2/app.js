const http = require('http')
const server = http.createServer((req, res) => {
   res.write("<h1>Greenwich Vietnam</h1>")
   res.write("<h2>2 Pham Van Bach - Cau Giay - Ha Noi</h2>")
   res.end()
})
server.listen(3000, () => {
   console.log("Server is running at http://localhost:3000")
})