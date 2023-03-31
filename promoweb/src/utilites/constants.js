const API_BASE_URL_DEVELOPMENT = "https://localhost:7107";

const ENDPOINTS = {
  GET_ALL_PROMO: "getallpromos",
  GET_PROMO_BY_ID: "getpromo-by-Id",
  CREATE_PROMO: "create-promo",
  UPDATE_PROMO: "update-promo",
  DELETE_PROMO: "deletepromo-by-id",
}

const development = {
  API_URL_GET_ALL_PROMO: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.GET_ALL_PROMO}`,
  API_URL_GET_PROMO_BY_ID: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.GET_PROMO_BY_ID}`,
  API_URL_CREATE_PROMO: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.CREATE_PROMO}`,
  API_URL_UPDATE_PROMO: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.UPDATE_PROMO}`,
  API_URL_DELETE_PROMO: `${API_BASE_URL_DEVELOPMENT}/${ENDPOINTS.DELETE_PROMO}`,
}

export const constantsURL = development;

export const columnDefs = [
  {
    field: 'promoId',
    headerName: 'PromoId',
    width: 30,
  },
  {
    field: 'promoTitle',
    headerName: 'Title',
  },
  {
    field: 'promoCurrency',
    headerName: 'Currency',
  },
  {
    field: 'promoType',
    headerName: 'Type',
  },
  {
    field: 'promoStart',
    headerName: 'Date Start',
  },
  {
    field: 'promoEnd',
    headerName: 'Date End',
  },
  {
    field: 'model',
    headerName: 'Model',
  },
  {
    field: 'channel',
    headerName: 'Channel',
  },
]
