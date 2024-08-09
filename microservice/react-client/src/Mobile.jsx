import axios from 'axios'
import { useState, useEffect } from 'react'

const Mobile = () => {
    const api = 'https://localhost:8888/mobiles'
    const [mobiles, setMobiles] = useState([])
    const [error, setError] = useState(null)

    useEffect(() => {
        const fetchData = async () => {
            try {
                const { data } = await axios.get(api)
                setMobiles(data)
            } catch (err) {
                setError(err.message)
            }
        }

        fetchData()
    }, [])

    if (error) {
        return <div>Error: {error}</div>
    }

    return (
        <div className="container text-center">
            <table className="table table-success mt-5">
                <thead>
                    <tr>
                        <th colSpan="3" className="h4 text-primary">MOBILE LIST</th>
                    </tr>
                    <tr>
                        <th>Mobile Id</th>
                        <th>Mobile Name</th>
                        <th>Mobile Price</th>
                    </tr>
                </thead>
                <tbody>
                    {mobiles.map((mobile) => (
                        <tr key={mobile.id}>
                            <td>{mobile.id}</td>
                            <td>{mobile.name}</td>
                            <td>${mobile.price}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    )
}

export default Mobile
