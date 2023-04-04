import React, { useState } from 'react'
import { constantsURL } from './utilites/constants';

export const CreatePromo = ({ getAllPromos, setMessge, isCreate, setIsUpdate, setIsCreate, promo}) => {
    const initialFormData = promo ? promo : {};

    const [formData, setFormData] = useState(initialFormData);

    const deletePromo = (promoId) => {
        const urlDeleteById = `${constantsURL.API_URL_DELETE_PROMO}/${promoId}`
    
        fetch(urlDeleteById, {
          method: 'DELETE'
        })
          .then(response => response.json())
          .then(response => {
            console.log(response);
            getAllPromos();
            setMessge(`Promo #${promoId} was deleted successful`)
          })
      }

    const handleChange = (e) => {
        if (e.nativeEvent.type === "date") {
            const newDate = new Date(e.target.value)
            setFormData({
                ...formData,
                [e.target.name]: newDate,
            });
        } else {
            setFormData({
                ...formData,
                [e.target.name]: e.target.value,
            });
        }
        
    };

    const handleSubmit = (e) => {
        e.preventDefault();

        const postForm = {
            promoId: 0,
            promoTitle: formData.promoTitle,
            promoType: formData.promoType,
            promoCurrency: formData.promoCurrency,
            promoStart: formData.promoStart,
            promoEnd: formData.promoEnd,
            model: formData.model,
            channel: formData.channel,
        };

        const urlCreate = constantsURL.API_URL_CREATE_PROMO;

        const urlUpdate = constantsURL.API_URL_UPDATE_PROMO;

        fetch(
            isCreate ? urlCreate : urlUpdate, {
            method: isCreate ? 'POST' : 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(postForm)
        })
            .then(response => response.json())
            .then(responseFromServer => {
                console.log(responseFromServer);
                isCreate ? setIsCreate(false) : setIsUpdate(false)
                setMessge(
                    isCreate
                    ? 'Promo created'
                    : `Promo #${postForm.promoId} was update successful`
                )
            })
            .catch((error) => {
                console.log(error);
                alert(error);
            });
    };
    
    return (
        <form className="w-100 px-5">
            <h1 className="mt-5">
                {
                    isCreate
                    ? 'Create new promo'
                    : 'Update promo'
                }
            </h1>

            <div className="mt-5">
                <label className="h3 form-label">Promo title</label>
                <input value={formData.promoTitle} name="promoTitle" type="text" className="form-control" onChange={handleChange} />
            </div>

            <div className="mt-4">
                <label className="h3 form-label">Promo model</label>
                <input value={formData.model} name="model" type="text" className="form-control" onChange={handleChange} />
            </div>

            <div className="mt-4">
                <label className="h3 form-label">Promo channel</label>
                <input value={formData.channel} name="channel" type="text" className="form-control" onChange={handleChange} />
            </div>

            <div className="mt-4">
                <label className="h3 form-label">Promo promoStart</label>
                <input value={formData.promoStart} name="promoStart" type="datetime-local" className="form-control" onChange={handleChange} />
            </div>

            <div className="mt-4">
                <label className="h3 form-label">Promo promoEnd</label>
                <input value={formData.promoEnd} name="promoEnd" type="datetime-local" className="form-control" onChange={handleChange} />
            </div>

            <div className="mt-4">
                <label className="h3 form-label">Promo promoType</label>
                <select value={formData.promoType} name="promoType" type="date" className="form-control" onChange={handleChange}>
                    <option className="options" value="0">DPD</option>
                    <option className="options" value="1">Credit</option>
                </select>    
            </div>
            <div className="mt-4">
                <label className="h3 form-label">Promo promoCurrency</label>
                <select value={formData.promoCurrency} name="promoCurrency" type="date" className="form-control" onChange={handleChange}>
                    <option className="options" value="0">RUB</option>
                    <option className="options" value="1">USD</option>
                </select>    
            </div>

            <button onClick={handleSubmit} className="btn btn-dark btn-lg w-100 mt-5">{
                isCreate ? 'Create promo' : 'Update promo' 
            }</button>
            {
                !isCreate && <button onClick={() => deletePromo(promo.promoId)} className="btn w-100 mt-5 btn-danger btn-lg">
                Delete promo
            </button>
            }
            <button onClick={() => {
                setIsCreate(false) 
                setIsUpdate(false)
                setFormData(initialFormData)
            }} className="btn btn-secondary btn-lg w-100 mt-3">Cancel</button>
        </form>
    );
}
