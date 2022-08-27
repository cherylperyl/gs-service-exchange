import axios from 'axios';

export default async function handler(req, res) {
  const params = new URLSearchParams({
    customerName: req.body.customerName,
    serviceId: req.body.serviceId,
  }).toString();
  const url = 'https://api.gsserviceexchange.online/api/' + req.headers.endpoint + '?' + params;
  try{
    const resp = await axios.post(url, req.body, {headers: {
      'Authorization': req.headers.authorization,
      'accept': 'text/plain'
      },
    });
    return res.status(200).json(resp.data)
  } catch (error) {
    console.error(error)
    return res.status(500).json(error)
  }
}