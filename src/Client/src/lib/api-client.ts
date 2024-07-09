/* eslint-disable no-param-reassign */

import axios from "axios";

export const api = axios.create({
  baseURL: "/api",
});

api.interceptors.request.use((config) => {
  if (config.headers) {
    config.headers.Accept = "application/json";
  }

  return config;
});
