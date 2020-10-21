import React from "react";
import logo from "./logo.svg";
import "./App.css";
import GetCompressedString from "./api/datamodelsapi";

export default class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      data: "",
    };
  }

  componentDidMount() {
    var response = GetCompressedString();

    this.setState({ data: response });
  }

  render() {
    return <React.Fragment>{this.state.data}</React.Fragment>;
  }
}
