import { NgModule, Component, enableProdMode } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import DataSource from 'devextreme/data/data_source';
import { DxBulletModule, DxTemplateModule } from 'devextreme-angular';
import { DxDataGridModule, DxDataGridTypes } from 'devextreme-angular/ui/data-grid';
import { Service } from './app.service';
import { DataService } from './data.service';
import { provideHttpClient } from '@angular/common/http';


@Component({
  selector: 'demo-app',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [Service],
})
export class AppComponent {
  dataSource: DataSource;

  collapsed = false;

  contentReady = (e: DxDataGridTypes.ContentReadyEvent) => {
    if (!this.collapsed) {
      this.collapsed = true;
      e.component.expandRow(['EnviroCare']);
    }
  };

  customizeTooltip = ({ originalValue }: Record<string, string>) => ({ text: `${parseInt(originalValue)}%` });

  constructor(service: Service) {
    this.dataSource = service.getDataSource();
  }
}

@NgModule({
  imports: [
    BrowserModule,
    DxDataGridModule,
    DxTemplateModule,
    DxBulletModule,
  ],
  providers: [provideHttpClient()],
  declarations: [AppComponent],
  bootstrap: [AppComponent],
})
export class AppModule { }

platformBrowserDynamic().bootstrapModule(AppModule);
