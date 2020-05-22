import axios, { AxiosInstance, AxiosResponse } from 'axios';
import { JsonConvert } from 'json2typescript';


export class ApiService {
    private static API_URI = "https://localhost:32770";
    private httpClient: AxiosInstance;
    protected jsonConvert: JsonConvert;

    constructor() {
        this.httpClient = this.createHttpClient();
        this.jsonConvert = new JsonConvert();
    }

    public async get<TResource>(type: (new () => TResource), resource: string): Promise<TResource> {
        const response = await this.httpClient.get(resource + '/');
        return this.jsonConvert.deserialize(response.data, type) as TResource;
    }

    public async postResource<TResource>(
        type: (new () => TResource),
        resource: string,
        payload?: TResource,
    ): Promise<TResource> {
        const serializedPayload = payload === undefined ? "{}" : this.jsonConvert.serializeObject(payload);
        const response = await this.httpClient.post(resource, serializedPayload);
        console.log(response.data);
        return this.jsonConvert.deserializeObject(response.data, type);
    }

    private createHttpClient(): AxiosInstance {
        const endpointUrl = this.getServiceUrl();

        return axios.create({
            baseURL: endpointUrl,
            timeout: 60000
        });
    }

    private getServiceUrl(): string {
        return ApiService.API_URI + '/api/';
    }
}
