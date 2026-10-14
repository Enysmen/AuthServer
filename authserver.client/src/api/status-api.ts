import { type ServiceStatus} from "../dtoservice.tsx";


export async function getServerStatus(): Promise<ServiceStatus | undefined> {

    try 
    {
        const response = await fetch('api/status');
        if (response.ok) {
            const data = await response.json();
            return data; 
        } else {
            throw new Error(`Server returned status code ${response.status}`);
        }
    }
    catch (error)
    {
        return Promise.reject(error);
    }


}