import React, {useState} from "react";
import { columnDefs, constantsURL } from "../utilites/constants";
import 'ag-grid-community/styles/ag-grid.css'; // Core grid CSS, always needed
import 'ag-grid-community/styles/ag-theme-alpine.css'; // Optional theme CSS
import { AgGridReact } from "ag-grid-react";

export const Table = ({ setMessge, getAllPromos, promos, setPromo, setIsUpdate={setIsUpdate} }) => {

  const getPromo = (promoId) => {
    const urlPromoById = `${constantsURL.API_URL_GET_PROMO_BY_ID}/${promoId}`

    fetch(urlPromoById, {
      method: 'GET'
    })
      .then(response => response.json())
      .then(promo => {
        setPromo(promo)
        setIsUpdate(true)
      })
  }

  const cellClickedListener = (params) => {
    const id = params.data.promoId
    getPromo(id)
  }

  return (
    <div className="table-responsive mt-5">
      <div className="ag-theme-alpine" style={{width: 1000, height: 500}}>
        <AgGridReact
          defaultColDef={{
            flex: 1,
            minWidth: 100,
            resizable: true,
            filter: true,
          }}
          rowData={promos} // Row Data for Rows
          columnDefs={columnDefs} // Column Defs for Columns // Default Column Properties
          // animateRows={true} // Optional - set to 'true' to have rows animate when sorted
          // rowSelection='multiple' // Options - allows click selection of rows
          onCellClicked={cellClickedListener} // Optional - registering for Grid Event
        />
      </div>
    </div>
  );
}
