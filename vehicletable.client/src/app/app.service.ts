import { Injectable } from '@angular/core';
import 'devextreme/data/odata/store';
import DataSource from 'devextreme/data/data_source';
import CustomStore from "devextreme/data/custom_store";
import { HttpClient } from '@angular/common/http';
import { DataService } from './data.service';
import { createStore } from 'devextreme-aspnet-data-nojquery';

@Injectable()
export class Service {
  constructor(private dataService: DataService) { }

  getDataSource() {
    const store = createStore({
        key: "cId",
        loadUrl: "https://localhost:7259/vehicles"
    });

    return new DataSource(store);
  }
}
