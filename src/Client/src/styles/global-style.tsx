import { createGlobalStyle } from "styled-components";

const GlobalStyle = createGlobalStyle`
  * {
    margin: 0; padding: 0;
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
