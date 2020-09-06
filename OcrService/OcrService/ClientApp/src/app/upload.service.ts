import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})

export class UploadService {
  SERVER_URL: string = "https://localhost:44325/ocr/upload";
  constructor(private httpClient: HttpClient) { }
  public upload(formData) {

    return this.httpClient.post<OcrResult>(this.SERVER_URL, formData, {
      reportProgress: true,
      observe: 'events'
    });
  }
}

interface OcrResult {
  totalAmount
}
