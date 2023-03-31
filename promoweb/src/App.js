import React, { useEffect, useState } from "react";
import { Table } from "./components/Table";
import { CreatePromo } from "./CreatePromo";
import { constantsURL } from "./utilites/constants";

export const App = () => {
  const [promos, setPromos] = useState([])
  const [promo, setPromo] = useState(null)
  const [message, setMessge] = useState('')
  const [isCreate, setIsCreate] = useState(false)
  const [isUpdate, setIsUpdate] = useState(false)

  const clearMessage = () => {
    setMessge('')
  }

  useEffect(() => {
    console.log(message);
    if (message !== '') {
      getAllPromos()
      setTimeout(clearMessage, 3000)
    }
  }, [message])



  const getAllPromos = () => {
    fetch(constantsURL.API_URL_GET_ALL_PROMO, {
      method: "GET",
    })
      .then((response) => response.json())
      .then((promosFromServer) => {
        setPromos(promosFromServer)
      })
      .catch((error) => {
        console.log(error);
      });
  };
  useEffect(() => {
    getAllPromos()
  }, [])
  return (
    <div className="container">
      <div className="row min-vh-100">
        <div className="col d-flex flex-column justify-content-center align-items-center">
          {message !== '' && <p className="alert alert-primary fixed-top text-center">{message}</p>}
          {
            !isCreate && !isUpdate
            ? (
              <div>
                <h1>Promos Table</h1>
                <div className="mt-5">
                  <button
                    className="btn btn-primary btn-lg w-100 mt-4"
                    onClick={() => {
                      setIsCreate(true)
                    }}
                  >
                    Create new promo
                  </button>
                </div>
                {promos.length > 0 ? <Table setMessge={setMessge} getAllPromos={getAllPromos} promos={promos} setPromo={setPromo} setIsUpdate={setIsUpdate} /> : ''}
              </div>
              )
            : (
              <div>
                <h1>Promo Create</h1>
                <div className="mt-5">
                  <CreatePromo setMessge={setMessge} promo={promo} isCreate={isCreate} setIsCreate={setIsCreate} setIsUpdate={setIsUpdate} />
                </div>
              </div>
              )
          }
        </div>
      </div>
    </div>
  );
}
