/*
 * Copyright 2012 www.xcenter.cn
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *      http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace System.Serialization {

    internal class InitJsonParser : JsonParserBase {

        private Object _result;

        public InitJsonParser( CharSource charSrc )
            : base( charSrc ) {
        }

        protected override void parse() {
            _result = moveAndGetParser().getResult();
        }

        public override Object getResult() {
            return _result;
        }

    }

}
