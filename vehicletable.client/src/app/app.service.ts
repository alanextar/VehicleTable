import { Injectable } from '@angular/core';
import 'devextreme/data/odata/store';
import DataSource from 'devextreme/data/data_source';
import { createStore } from 'devextreme-aspnet-data-nojquery';

@Injectable()
export class Service {
  getDataSource() {
    const store = createStore({
        key: "cId",
        loadUrl: "https://localhost:7259/vehicles"
    });

    return new DataSource(store);
  }
}
