/* ਀ ⨀ 䰀椀挀攀渀猀攀搀 琀漀 琀栀攀 䄀瀀愀挀栀攀 匀漀昀琀眀愀爀攀 䘀漀甀渀搀愀琀椀漀渀 ⠀䄀匀䘀⤀ 甀渀搀攀爀 漀渀攀 漀爀 洀漀爀攀 
 * contributor license agreements.  See the NOTICE file distributed with਀ ⨀ 琀栀椀猀 眀漀爀欀 昀漀爀 愀搀搀椀琀椀漀渀愀氀 椀渀昀漀爀洀愀琀椀漀渀 爀攀最愀爀搀椀渀最 挀漀瀀礀爀椀最栀琀 漀眀渀攀爀猀栀椀瀀⸀ 
 * The ASF licenses this file to You under the Apache License, Version 2.0਀ ⨀ ⠀琀栀攀 ∀䰀椀挀攀渀猀攀∀⤀㬀 礀漀甀 洀愀礀 渀漀琀 甀猀攀 琀栀椀猀 昀椀氀攀 攀砀挀攀瀀琀 椀渀 挀漀洀瀀氀椀愀渀挀攀 眀椀琀栀 
 * the License.  You may obtain a copy of the License at਀ ⨀  
 * http://www.apache.org/licenses/LICENSE-2.0਀ ⨀  
 * Unless required by applicable law or agreed to in writing, software਀ ⨀ 搀椀猀琀爀椀戀甀琀攀搀 甀渀搀攀爀 琀栀攀 䰀椀挀攀渀猀攀 椀猀 搀椀猀琀爀椀戀甀琀攀搀 漀渀 愀渀 ∀䄀匀 䤀匀∀ 䈀䄀匀䤀匀Ⰰ 
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.਀ ⨀ 匀攀攀 琀栀攀 䰀椀挀攀渀猀攀 昀漀爀 琀栀攀 猀瀀攀挀椀昀椀挀 氀愀渀最甀愀最攀 最漀瘀攀爀渀椀渀最 瀀攀爀洀椀猀猀椀漀渀猀 愀渀搀 
 * limitations under the License.਀ ⨀⼀ 
਀甀猀椀渀最 匀礀猀琀攀洀㬀 
using System.Collections;਀甀猀椀渀最 匀礀猀琀攀洀⸀䌀漀氀氀攀挀琀椀漀渀猀⸀䜀攀渀攀爀椀挀㬀 
using System.Text;਀甀猀椀渀最 匀礀猀琀攀洀⸀䤀伀㬀 
਀甀猀椀渀最 䰀甀挀攀渀攀⸀一攀琀⸀䄀渀愀氀礀猀椀猀㬀 
using Lucene.Net.Analysis.Tokenattributes;਀甀猀椀渀最 䰀甀挀攀渀攀⸀一攀琀⸀唀琀椀氀㬀 
਀ 
namespace Lucene.Net.Analysis.Ext਀笀 
    /// <summary>਀    ⼀⼀⼀ 吀栀椀猀 愀渀愀氀礀稀攀爀 琀愀爀最攀琀猀 猀栀漀爀琀 昀椀攀氀搀猀 眀栀攀爀攀 ⨀眀漀爀搀⨀ 氀椀欀攀 猀攀愀爀挀栀攀猀 愀爀攀 爀攀焀甀椀爀攀搀⸀ 
    /// [SomeUser@GMAIL.com 1234567890] will be tokenized as਀    ⼀⼀⼀ 嬀猀⸀漀⸀洀⸀攀⸀甀⸀猀⸀攀⸀爀⸀⸀最⸀洀⸀愀⸀椀⸀氀⸀⸀挀漀洀⸀⸀㄀⸀㈀⸀㌀⸀㐀⸀㔀⸀㘀⸀㜀⸀㠀⸀㤀⸀　崀 ⠀爀攀愀搀 ⸀✀猀 愀猀 戀氀愀渀欀⤀ 
    /// ਀    ⼀⼀⼀ 唀猀愀最攀㨀  
    /// QueryParser p = new QueryParser(Lucene.Net.Util.Version.LUCENE_29, "fieldName", new SingleCharTokenAnalyzer());਀    ⼀⼀⼀ 瀀⸀匀攀琀䐀攀昀愀甀氀琀伀瀀攀爀愀琀漀爀⠀儀甀攀爀礀倀愀爀猀攀爀⸀伀瀀攀爀愀琀漀爀⸀䄀一䐀⤀㬀 
    /// p.SetEnablePositionIncrements(true);਀    ⼀⼀⼀  
    /// TopDocs td = src.Search(p.Parse("678"), 10);਀    ⼀⼀⼀ 漀爀 
    /// TopDocs td = src.Search(p.Parse("\"gmail.com 1234\""), 10);਀    ⼀⼀⼀ 㰀⼀猀甀洀洀愀爀礀㸀 
    public class SingleCharTokenAnalyzer : Analyzer਀    笀 
        /// <summary>਀        ⼀⼀⼀ 㰀⼀猀甀洀洀愀爀礀㸀 
        public override TokenStream TokenStream(string fieldName, TextReader reader)਀        笀 
            TokenStream t = null;਀            琀 㴀 渀攀眀 䰀攀琀琀攀爀伀爀䐀椀最椀琀吀漀欀攀渀椀稀攀爀⠀爀攀愀搀攀爀⤀㬀 
            t = new LowerCaseFilter(t);਀            琀 㴀 渀攀眀 䄀匀䌀䤀䤀䘀漀氀搀椀渀最䘀椀氀琀攀爀⠀琀⤀㬀 
            t = new SingleCharTokenizer(t);਀ 
            return t;਀        紀 
                ਀        挀氀愀猀猀 匀椀渀最氀攀䌀栀愀爀吀漀欀攀渀椀稀攀爀 㨀 吀漀欀攀渀椀稀攀爀 
        {਀            吀漀欀攀渀匀琀爀攀愀洀 开椀渀瀀甀琀 㴀 渀甀氀氀㬀 
਀            䤀吀攀爀洀䄀琀琀爀椀戀甀琀攀 开琀攀爀洀䄀琀琀爀椀戀甀琀攀 㴀 渀甀氀氀㬀 
            IOffsetAttribute _offsetAttribute = null;਀            䤀倀漀猀椀琀椀漀渀䤀渀挀爀攀洀攀渀琀䄀琀琀爀椀戀甀琀攀 开瀀漀猀椀琀椀漀渀䤀渀挀爀攀洀攀渀琀䄀琀琀爀椀戀甀琀攀 㴀 渀甀氀氀㬀 
਀            挀栀愀爀嬀崀 开戀甀昀昀攀爀 㴀 渀甀氀氀㬀 
            int _offset = -1;਀            椀渀琀 开氀攀渀最琀栀 㴀 ⴀ㄀㬀 
            int _offsetInStream = -1;਀ 
            public SingleCharTokenizer(TokenStream input): base(input)਀            笀 
                _input = input;਀                开琀攀爀洀䄀琀琀爀椀戀甀琀攀 㴀 䄀搀搀䄀琀琀爀椀戀甀琀攀㰀䤀吀攀爀洀䄀琀琀爀椀戀甀琀攀㸀⠀⤀㬀 
                _offsetAttribute = AddAttribute<IOffsetAttribute>();਀                开瀀漀猀椀琀椀漀渀䤀渀挀爀攀洀攀渀琀䄀琀琀爀椀戀甀琀攀 㴀 䄀搀搀䄀琀琀爀椀戀甀琀攀㰀䤀倀漀猀椀琀椀漀渀䤀渀挀爀攀洀攀渀琀䄀琀琀爀椀戀甀琀攀㸀⠀⤀㬀 
            }਀ 
            public override bool IncrementToken()਀            笀 
                int positionIncrement = 0;਀                椀昀 ⠀开戀甀昀昀攀爀 㴀㴀 渀甀氀氀 簀簀 开漀昀昀猀攀琀 㸀㴀 开氀攀渀最琀栀⤀ 
                {਀                    椀昀 ⠀℀开椀渀瀀甀琀⸀䤀渀挀爀攀洀攀渀琀吀漀欀攀渀⠀⤀⤀ 爀攀琀甀爀渀 昀愀氀猀攀㬀 
਀                    开漀昀昀猀攀琀 㴀 　㬀 
                    _buffer = _termAttribute.TermBuffer();਀                    开氀攀渀最琀栀 㴀 开琀攀爀洀䄀琀琀爀椀戀甀琀攀⸀吀攀爀洀䰀攀渀最琀栀⠀⤀㬀 
                    positionIncrement++;਀                    开漀昀昀猀攀琀䤀渀匀琀爀攀愀洀⬀⬀㬀 
                }਀ 
                _offsetAttribute.SetOffset(_offsetInStream, _offsetInStream + 1);਀                开漀昀昀猀攀琀䤀渀匀琀爀攀愀洀⬀⬀㬀 
਀                瀀漀猀椀琀椀漀渀䤀渀挀爀攀洀攀渀琀⬀⬀㬀 
                _positionIncrementAttribute.PositionIncrement = positionIncrement;਀ 
                _termAttribute.SetTermLength(1);਀                开琀攀爀洀䄀琀琀爀椀戀甀琀攀⸀匀攀琀吀攀爀洀䈀甀昀昀攀爀⠀开戀甀昀昀攀爀嬀开漀昀昀猀攀琀⬀⬀崀⸀吀漀匀琀爀椀渀最⠀⤀⤀㬀 
਀                爀攀琀甀爀渀 琀爀甀攀㬀 
            }਀ 
            public override void Reset()਀            笀 
                _buffer = null;਀                开漀昀昀猀攀琀 㴀 ⴀ㄀㬀 
                _length = -1;਀                开漀昀昀猀攀琀䤀渀匀琀爀攀愀洀 㴀 ⴀ㄀㬀 
਀                戀愀猀攀⸀刀攀猀攀琀⠀⤀㬀 
            }਀ 
            protected override void Dispose(bool disposing)਀            笀 
                _input.Close();਀                戀愀猀攀⸀䐀椀猀瀀漀猀攀⠀搀椀猀瀀漀猀椀渀最⤀㬀 
            }਀        紀 
    }਀ 
    /// <summary>਀    ⼀⼀⼀ 䄀渀漀琀栀攀爀 䄀渀愀氀礀稀攀爀⸀ 䔀瘀攀爀礀 挀栀愀爀 眀栀椀挀栀 椀猀 渀漀琀 愀 氀攀琀琀攀爀 漀爀 搀椀最椀琀 椀猀 琀爀攀愀琀攀搀 愀猀 愀 眀漀爀搀 猀攀瀀愀爀愀琀漀爀⸀ 
    /// [Name.Surname@gmail.com 123.456 ğüşıöç%ĞÜŞİÖÇ$ΑΒΓΔΕΖ#АБВГДЕ SSß] will be tokenized as਀    ⼀⼀⼀ 嬀渀愀洀攀 猀甀爀渀愀洀攀 最洀愀椀氀 挀漀洀 ㄀㈀㌀ 㐀㔀㘀 最甀猀椀漀挀 最甀猀椀漀挀 넀눃댃됃딃똃 　㄄㈄㌄㐄㔄 猀猀猀猀崀 
    /// ਀    ⼀⼀⼀ 一漀 瀀爀漀戀氀攀洀 眀椀琀栀 猀攀愀爀挀栀攀猀 氀椀欀攀 猀漀洀攀甀猀攀爀䀀最洀愀椀氀 漀爀 ㄀㈀㌀⸀㐀㔀㘀 猀椀渀挀攀 琀栀攀礀 愀爀攀 
    /// converted to phrase-query as "someuser gmail" or "123 456".਀    ⼀⼀⼀ 㰀⼀猀甀洀洀愀爀礀㸀 
    public class UnaccentedWordAnalyzer : Analyzer਀    笀 
        /// <summary>਀        ⼀⼀⼀ 㰀⼀猀甀洀洀愀爀礀㸀 
        public override TokenStream TokenStream(string fieldName, TextReader reader)਀        笀 
            TokenStream t = null;਀            琀 㴀 渀攀眀 䰀攀琀琀攀爀伀爀䐀椀最椀琀吀漀欀攀渀椀稀攀爀⠀爀攀愀搀攀爀⤀㬀 
            t = new LowerCaseFilter(t);਀            琀 㴀 渀攀眀 䄀匀䌀䤀䤀䘀漀氀搀椀渀最䘀椀氀琀攀爀⠀琀⤀㬀 
਀            爀攀琀甀爀渀 琀㬀 
        }਀    紀 
਀    ⼀⼀⼀ 㰀猀甀洀洀愀爀礀㸀 
    /// if a char is not a letter or digit, it is a word separator਀    ⼀⼀⼀ 㰀⼀猀甀洀洀愀爀礀㸀 
    public class LetterOrDigitTokenizer : CharTokenizer਀    笀 
        /// <summary>਀        ⼀⼀⼀ 㰀⼀猀甀洀洀愀爀礀㸀 
        public LetterOrDigitTokenizer(TextReader reader): base(reader)਀        笀 
        }਀ 
        /// <summary>਀        ⼀⼀⼀ 㰀⼀猀甀洀洀愀爀礀㸀 
        protected override bool IsTokenChar(char c)਀        笀 
            return char.IsLetterOrDigit(c);਀        紀 
    }਀紀 
