import { createGlobalStyle } from "styled-components";

import backgroundTexture from "@/assets/background-paper-texture.jpeg";

const GlobalStyle = createGlobalStyle`
  * {
    margin: 0; padding: 0;
    box-sizing: border-box;
    border: none;
    outline: none;
    text-decoration: none;
  }

  html {
    scroll-behavior: smooth;
  }

  body {
    background: url("${backgroundTexture}") no-repeat center;
    background-size: cover;
    background-origin: border-box;
    color: #091c0c
  }

  button {
    background: none;
    font: inherit;
    border: none;
    cursor: pointer;
  }
`;

export default GlobalStyle;
