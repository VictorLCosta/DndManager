import { createGlobalStyle } from "styled-components";

const GlobalStyle = createGlobalStyle`
  * {
    margin: 0; padding: 0;
    border: none;
    outline: none;
    text-decoration: none;
  }

  html {
    box-sizing: border-box;
  }


  *, *::before, *::after {
    box-sizing: inherit;
  }

  ul {
    list-style: none;
  }

  button {
    background: none;
    font: inherit;
    cursor: pointer;
  }

  img,
  video {
    height: auto;
    max-width: 100%;
  }

  iframe {
    border: 0;
  }
`;

export default GlobalStyle;
