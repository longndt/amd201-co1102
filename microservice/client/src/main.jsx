import React from 'react'
import ReactDOM from 'react-dom/client'
import './index.css'
import Laptop from './Laptop'
import Mobile from './Mobile'


ReactDOM.createRoot(document.getElementById('root')).render(
    <React.StrictMode>
        <div class="row">
            <div class="col">
                <Laptop />
            </div>
            <div class="col">
                <Mobile />
            </div>
        </div>
    </React.StrictMode>
)
