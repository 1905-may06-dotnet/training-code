/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, { enumerable: true, get: getter });
/******/ 		}
/******/ 	};
/******/
/******/ 	// define __esModule on exports
/******/ 	__webpack_require__.r = function(exports) {
/******/ 		if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 			Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 		}
/******/ 		Object.defineProperty(exports, '__esModule', { value: true });
/******/ 	};
/******/
/******/ 	// create a fake namespace object
/******/ 	// mode & 1: value is a module id, require it
/******/ 	// mode & 2: merge all properties of value into the ns
/******/ 	// mode & 4: return value when already ns object
/******/ 	// mode & 8|1: behave like require
/******/ 	__webpack_require__.t = function(value, mode) {
/******/ 		if(mode & 1) value = __webpack_require__(value);
/******/ 		if(mode & 8) return value;
/******/ 		if((mode & 4) && typeof value === 'object' && value && value.__esModule) return value;
/******/ 		var ns = Object.create(null);
/******/ 		__webpack_require__.r(ns);
/******/ 		Object.defineProperty(ns, 'default', { enumerable: true, value: value });
/******/ 		if(mode & 2 && typeof value != 'string') for(var key in value) __webpack_require__.d(ns, key, function(key) { return value[key]; }.bind(null, key));
/******/ 		return ns;
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(__webpack_require__.s = "./out/main.js");
/******/ })
/************************************************************************/
/******/ ({

/***/ "./out/card-service.js":
/*!*****************************!*\
  !*** ./out/card-service.js ***!
  \*****************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
eval("\r\nObject.defineProperty(exports, \"__esModule\", { value: true });\r\nclass CardService {\r\n    static getUrlDrawDeck(deckid, count) {\r\n        return `https://deckofcardsapi.com/api/deck/${deckid}/draw/?count=${count}`;\r\n    }\r\n    createDeck() {\r\n        return fetch(CardService.urlNewDeck)\r\n            .then(function (response) {\r\n            return response.json();\r\n        });\r\n    }\r\n    drawDeck(deckid, count = 1) {\r\n        return fetch(CardService.getUrlDrawDeck(deckid, count))\r\n            .then(res => res.json())\r\n            .catch(res => res);\r\n    }\r\n}\r\nCardService.urlNewDeck = \"https://deckofcardsapi.com/api/deck/new/\";\r\nexports.CardService = CardService;\r\n\n\n//# sourceURL=webpack:///./out/card-service.js?");

/***/ }),

/***/ "./out/main.js":
/*!*********************!*\
  !*** ./out/main.js ***!
  \*********************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
eval("\r\nObject.defineProperty(exports, \"__esModule\", { value: true });\r\nconst card_service_1 = __webpack_require__(/*! ./card-service */ \"./out/card-service.js\");\r\nclass Main {\r\n    constructor() { }\r\n    static Main() {\r\n        var newDeck = document.getElementById(\"newDeck\");\r\n        var drawCard = document.getElementById(\"drawCard\");\r\n        var container = document.getElementById(\"container\");\r\n        var deckId;\r\n        let service = new card_service_1.CardService();\r\n        newDeck.addEventListener(\"click\", () => {\r\n            service.createDeck()\r\n                .then(res => {\r\n                drawCard.disabled = false;\r\n                container.innerHTML = '';\r\n                deckId = res.deck_id;\r\n                console.log(deckId);\r\n            })\r\n                .catch(console.log);\r\n        });\r\n        drawCard.onclick = () => {\r\n            service.drawDeck(deckId)\r\n                .then(res => {\r\n                let image = document.createElement('img');\r\n                image.src = res.cards[0].image;\r\n                container.appendChild(image);\r\n                console.log(res.cards[0].image);\r\n            })\r\n                .catch(console.log);\r\n        };\r\n    }\r\n}\r\nexports.Main = Main;\r\nMain.Main();\r\n\n\n//# sourceURL=webpack:///./out/main.js?");

/***/ })

/******/ });