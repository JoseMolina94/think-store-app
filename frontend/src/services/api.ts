const API_BASE_URL = 'http://localhost:5000/api'

// Función helper para manejar errores de fetch
const handleResponse = async (response: Response) => {
  if (!response.ok) {
    throw new Error(`HTTP error! status: ${response.status}`)
  }
  return response.json()
}

// API service usando fetch nativo
export const api = {
  // GET request
  async get(endpoint: string) {
    const response = await fetch(`${API_BASE_URL}${endpoint}`)
    return handleResponse(response)
  },

  // POST request
  async post(endpoint: string, data: any) {
    const response = await fetch(`${API_BASE_URL}${endpoint}`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(data),
    })
    return handleResponse(response)
  },

  // PUT request
  async put(endpoint: string, data: any) {
    const response = await fetch(`${API_BASE_URL}${endpoint}`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(data),
    })
    return handleResponse(response)
  },

  // DELETE request
  async delete(endpoint: string) {
    const response = await fetch(`${API_BASE_URL}${endpoint}`, {
      method: 'DELETE',
    })
    return handleResponse(response)
  },
}

export default api 