import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <div>
              <h1 class="alert alert-danger">Hello React !</h1>
              <br /> 
              <button class="btn btn-primary">Click me</button>
              <br />    <br /> 
              <table class="table table-success">
                  <thead>
                      <tr>
                          <th>Name</th>
                          <th>Gender</th>
                      </tr>
                  </thead>
                  <tbody>
                      <tr>
                          <td>Minh</td>
                          <td>Male</td>
                      </tr>
                      <tr>
                          <td>Huong</td>
                          <td>Female</td>
                      </tr>
                  </tbody>
              </table>
              <img src="https://bs-uploads.toptal.io/blackfish-uploads/components/blog_post_page/5992673/cover_image/retina_1708x683/1005_Design-Patterns-in-React_Cover-44247834a5b31e8d08e5bbbdac4a6750.png"
                  width="50%" height="50%"></img>
                  <br />
              <iframe width="560" height="315" src="https://www.youtube.com/embed/x0fSBAgBrOQ?si=0Xd3HQFluHqRp8KA" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>
      </div>
    </>
  )
}

export default App
