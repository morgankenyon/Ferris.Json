## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SerializationBenchmarks.FerrisValueLoopMapping()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+0C],0
       jle       near ptr M00_L02
M00_L00:
       mov       rcx,21B61404188
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+30]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFC8D9D66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+40],0
       jne       short M00_L03
       mov       rcx,21B61401EB8
       mov       rcx,[rcx]
M00_L01:
       mov       rdx,rdi
       call      qword ptr [7FFC8DE95EF0]; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
       mov       rcx,rax
       mov       ebp,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,6908B3E3
       mov       r9d,0C7B8688A
       call      qword ptr [7FFC8DF15410]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,ebp
       mov       [rbx+8],eax
       inc       esi
       cmp       esi,[rbx+0C]
       jl        near ptr M00_L00
M00_L02:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L03:
       cmp       dword ptr [rsp+40],1
       je        short M00_L07
       mov       ebp,[rsp+40]
       test      ebp,ebp
       jl        near ptr M00_L10
       mov       r14,[rsp+30]
       test      r14,r14
       je        near ptr M00_L11
       cmp       [r14+8],ebp
       je        short M00_L06
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       lea       rcx,[r15+10]
       lea       rdx,[r14+10]
       mov       r8d,[r14+8]
       cmp       ebp,r8d
       jg        short M00_L08
       mov       r8d,ebp
M00_L04:
       mov       r8d,r8d
       shl       r8,3
       cmp       r8,4000
       ja        short M00_L09
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L05:
       mov       [rsp+30],r15
M00_L06:
       mov       ecx,[rsp+40]
       mov       [rsp+44],ecx
       mov       rcx,[rsp+30]
       jmp       near ptr M00_L01
M00_L07:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       mov       rcx,rbp
       mov       r8,[rsp+38]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rbp
       jmp       near ptr M00_L01
M00_L08:
       jmp       short M00_L04
M00_L09:
       call      qword ptr [7FFC8DB35BD8]
       jmp       short M00_L05
M00_L10:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFC8DC2ED48]
       int       3
M00_L11:
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+30],rax
       jmp       short M00_L06
; Total bytes of code 412
```
```assembly
; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14,[rsp+0D0]
       xor       r15d,r15d
       xor       r13d,r13d
       test      rdi,rdi
       jne       near ptr M01_L12
M01_L00:
       xor       r12d,r12d
M01_L01:
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        near ptr M01_L11
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L11
       mov       rbp,rax
M01_L02:
       mov       [rsp+38],rdi
       cmp       [rbp],bpl
       lea       rdx,[rbp+60]
       mov       [rsp+30],rdx
       mov       r8,[rdx]
       test      r8,r8
       jne       near ptr M01_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimePropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       mov       rcx,[rsp+30]
       mov       rdx,rbp
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       r8,rax
       test      r8,r8
       cmove     r8,rbp
       mov       rax,[rsp+38]
M01_L03:
       mov       rbp,r8
       cmp       [rbp],bpl
       cmp       r12d,1
       je        near ptr M01_L16
       cmp       r12d,2
       je        near ptr M01_L18
       cmp       byte ptr [rbp+18],0
       je        near ptr M01_L14
       mov       r12,[rbp+8]
M01_L04:
       xor       ebx,2
       mov       ebp,[r12+8]
       mov       ecx,ebp
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       [rsp+58],r8
       mov       [rsp+60],r8d
       mov       [rsp+64],ecx
       xor       eax,eax
       test      ebp,ebp
       jle       short M01_L10
M01_L05:
       mov       [rsp+4C],eax
       mov       ecx,eax
       mov       r10,[r12+rcx*8+10]
       mov       [rsp+40],r10
       mov       ecx,[r10+58]
       mov       r8d,ebx
       and       r8d,ecx
       cmp       r8d,ecx
       je        short M01_L08
M01_L06:
       mov       eax,[rsp+4C]
       inc       eax
       cmp       ebp,eax
       jg        short M01_L05
       jmp       short M01_L10
M01_L07:
       mov       rax,[rsp+38]
       jmp       near ptr M01_L03
M01_L08:
       test      r15d,r15d
       jne       near ptr M01_L20
       test      r14,r14
       jne       near ptr M01_L21
M01_L09:
       lea       rcx,[rsp+50]
       mov       r8,r10
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFC8DC84F60]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       short M01_L06
M01_L10:
       mov       rdx,[rsp+50]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rsp+60]
       mov       [rsi+10],eax
       mov       eax,[rsp+64]
       mov       [rsi+14],eax
       mov       rax,rsi
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L11:
       mov       rcx,rbp
       call      qword ptr [7FFC8D9D6658]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
       jmp       near ptr M01_L02
M01_L12:
       test      bl,1
       je        short M01_L15
       mov       rcx,21B61400590
       mov       rcx,[rcx]
       mov       rdx,rdi
       call      qword ptr [7FFC8DBDC1C8]; System.Globalization.TextInfo.ToLower(System.String)
       mov       rdi,rax
       mov       r13d,1
       mov       r12d,2
M01_L13:
       cmp       byte ptr [rsp+0D8],0
       jne       near ptr M01_L22
       jmp       near ptr M01_L01
M01_L14:
       mov       rcx,rbp
       mov       r8d,r12d
       xor       edx,edx
       mov       r9d,3
       call      qword ptr [7FFC8DC867F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
       jmp       near ptr M01_L04
M01_L15:
       mov       r12d,1
       jmp       short M01_L13
M01_L16:
       lea       rcx,[rbp+20]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFC8DC85008]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L17
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FFC8DC867F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
M01_L17:
       jmp       near ptr M01_L04
M01_L18:
       lea       rcx,[rbp+28]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFC8DC85008]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L19
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       mov       r8d,2
       mov       r9d,3
       call      qword ptr [7FFC8DC867F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
M01_L19:
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,r10
       mov       rdx,rdi
       mov       r8d,r13d
       call      qword ptr [7FFC8D9D6538]
       test      eax,eax
       je        near ptr M01_L06
       mov       r10,[rsp+40]
       test      r14,r14
       je        near ptr M01_L09
M01_L21:
       mov       rcx,r10
       call      qword ptr [7FFC8DD3D8F0]; Precode of System.Reflection.RuntimePropertyInfo.GetIndexParameters()
       mov       eax,[rax+8]
       cmp       eax,[r14+8]
       jne       near ptr M01_L06
       mov       r10,[rsp+40]
       jmp       near ptr M01_L09
M01_L22:
       mov       rcx,rdi
       mov       edx,2A
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DA86160]; System.String.EndsWith(Char)
       test      eax,eax
       je        near ptr M01_L01
       mov       r8d,[rdi+8]
       dec       r8d
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFC8DA87240]; System.String.Substring(Int32, Int32)
       mov       rdi,rax
       mov       r15d,1
       jmp       near ptr M01_L00
; Total bytes of code 803
```
```assembly
; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
M02_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,298
       vzeroupper
       vmovaps   [rsp+280],xmm6
       vmovaps   [rsp+270],xmm7
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0D0],xmm4
       vmovdqa   xmmword ptr [rsp+0E0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M02_L01:
       vmovdqa   xmmword ptr [rsp+rax+270],xmm4
       vmovdqa   xmmword ptr [rsp+rax+280],xmm4
       vmovdqa   xmmword ptr [rsp+rax+290],xmm4
       add       rax,30
       jne       short M02_L01
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M02_L115
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M02_L02:
       xor       ebp,ebp
       cmp       dword ptr [rsi+8],0
       jle       near ptr M02_L31
M02_L03:
       mov       ecx,ebp
       mov       r14,[rsi+rcx*8+10]
       mov       r15,[r14]
       mov       r13,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r15,r13
       jne       near ptr M02_L116
       mov       rcx,r14
       cmp       qword ptr [rcx+18],0
       jne       short M02_L05
       xor       ecx,ecx
M02_L04:
       test      rcx,rcx
       je        near ptr M02_L106
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFC8DC73210]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r12,rax
       jmp       short M02_L06
M02_L05:
       mov       rcx,[r14+18]
       jmp       short M02_L04
M02_L06:
       cmp       r15,r13
       jne       near ptr M02_L210
       mov       rcx,r14
       cmp       qword ptr [rcx+38],0
       je        short M02_L09
M02_L07:
       mov       rdx,[r14+38]
       mov       rax,[rdx+18]
M02_L08:
       mov       r10,rax
       mov       [rsp+0C8],r10
       mov       rdx,offset MT_System.RuntimeType
       cmp       [r10],rdx
       jne       near ptr M02_L212
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+1F8]
       mov       rcx,r10
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFC8D9D66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+208],0
       jne       near ptr M02_L35
       mov       rdx,21B61401EB8
       mov       rax,[rdx]
       jmp       near ptr M02_L13
M02_L09:
       mov       rcx,[r14+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rsp+0B0],rax
       cmp       [rax],al
       mov       rcx,rax
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rdx,[rsp+0B0]
       mov       [rsp+238],rdx
       mov       [rsp+240],rax
       lea       rdx,[rsp+218]
       mov       [rsp+20],rdx
       mov       edx,[r14+50]
       lea       rcx,[rsp+238]
       lea       r8,[rsp+230]
       lea       r9,[rsp+228]
       call      qword ptr [7FFC8DCE5DE8]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       rax,[rsp+220]
       mov       [rsp+210],rax
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0B8],rax
       mov       r9,[r14+30]
       mov       rcx,rax
       mov       rdx,[rsp+210]
       mov       r8d,[rsp+218]
       call      qword ptr [7FFC8DC87AC8]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       lea       rcx,[r14+38]
       mov       rdx,[rsp+0B8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L07
M02_L10:
       mov       rdx,r10
       call      qword ptr [7FFC8DB35BD8]
M02_L11:
       mov       rcx,[rsp+98]
       mov       [rsp+1F8],rcx
M02_L12:
       mov       ecx,[rsp+208]
       mov       [rsp+20C],ecx
       mov       rax,[rsp+1F8]
M02_L13:
       mov       rdx,rax
M02_L14:
       mov       [rsp+0C0],rdx
       test      r12,r12
       je        near ptr M02_L104
       mov       rcx,21B00200020
       mov       rax,[rsp+0C8]
       cmp       rax,rcx
       je        near ptr M02_L56
       mov       rcx,21B002087B8
       cmp       rax,rcx
       je        near ptr M02_L56
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M02_L117
       mov       rcx,rax
       call      qword ptr [7FFC8D9D7330]; System.RuntimeType.GetBaseType()
       mov       rcx,21B002021B8
       cmp       rax,rcx
       je        near ptr M02_L118
M02_L15:
       mov       rcx,21B00208820
       mov       r8,[rsp+0C8]
       cmp       r8,rcx
       je        near ptr M02_L16
       mov       rcx,21B00208660
       cmp       r8,rcx
       je        near ptr M02_L16
       mov       rcx,21B00204FC0
       cmp       r8,rcx
       je        near ptr M02_L16
       mov       rcx,21B00208848
       cmp       r8,rcx
       je        near ptr M02_L16
       mov       rcx,21B00205F58
       cmp       r8,rcx
       je        near ptr M02_L16
       mov       rcx,21B00208870
       cmp       r8,rcx
       je        near ptr M02_L16
       mov       rcx,21B00208898
       cmp       r8,rcx
       je        near ptr M02_L16
       mov       rcx,21B002088C0
       cmp       r8,rcx
       je        short M02_L16
       mov       rcx,21B002088E8
       cmp       r8,rcx
       je        short M02_L16
       mov       rcx,21B00205718
       cmp       r8,rcx
       je        short M02_L16
       mov       rcx,21B00208910
       cmp       r8,rcx
       je        short M02_L16
       mov       rcx,21B00208938
       cmp       r8,rcx
       je        short M02_L16
       mov       rcx,21B00208960
       cmp       r8,rcx
       je        short M02_L16
       mov       rcx,21B00204B88
       cmp       r8,rcx
       je        short M02_L16
       mov       rcx,21B00208988
       cmp       r8,rcx
       jne       near ptr M02_L75
M02_L16:
       xor       ecx,ecx
       mov       [rsp+248],rcx
       mov       rcx,21B61401E70
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFC8DC69EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+250],rax
       test      rax,rax
       je        near ptr M02_L120
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M02_L17:
       mov       [rsp+260],rdx
       mov       [rsp+268],eax
       xor       ecx,ecx
       mov       [rsp+258],ecx
       mov       byte ptr [rsp+25C],0
       mov       ecx,[rsp+258]
       cmp       ecx,[rsp+268]
       ja        near ptr M02_L114
       mov       rax,[rsp+260]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+268]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L121
       mov       rcx,21B00208784
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+258]
       inc       ecx
       mov       [rsp+258],ecx
M02_L18:
       cmp       r15,r13
       jne       near ptr M02_L79
       mov       r15,[r14+8]
       test      r15,r15
       je        near ptr M02_L51
M02_L19:
       cmp       byte ptr [rsp+25C],0
       jne       near ptr M02_L80
M02_L20:
       test      r15,r15
       je        near ptr M02_L80
       mov       r8d,[rsp+258]
       cmp       r8d,[rsp+268]
       ja        near ptr M02_L114
       mov       rcx,[rsp+260]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+268]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L80
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC8DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+258]
       add       edx,[r15+8]
       mov       [rsp+258],edx
M02_L21:
       mov       edx,[rsp+258]
       cmp       edx,[rsp+268]
       ja        near ptr M02_L114
       mov       rcx,[rsp+260]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+268]
       sub       eax,edx
       cmp       eax,2
       jb        near ptr M02_L81
       mov       rdx,21B0020880C
       mov       eax,[rdx]
       mov       [rcx],eax
       mov       edx,[rsp+258]
       add       edx,2
       mov       [rsp+258],edx
M02_L22:
       mov       [rsp+160],r12
       cmp       byte ptr [rsp+25C],0
       jne       near ptr M02_L125
       mov       rdx,[rsp+160]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC8DA84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L89
       mov       rdx,[rsp+160]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC8DA84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L50
M02_L23:
       mov       rdx,[rsp+160]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC8DA843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       edx,[rsp+258]
       cmp       edx,[rsp+268]
       ja        near ptr M02_L114
       mov       rcx,[rsp+260]
       mov       r8d,edx
       lea       r14,[rcx+r8*2]
       mov       r13d,[rsp+268]
       sub       r13d,edx
       xor       r12d,r12d
       mov       rdx,offset MT_System.Double
       cmp       [rax],rdx
       jne       near ptr M02_L37
       add       rax,8
       mov       r15,[rsp+248]
       vmovsd    xmm7,qword ptr [rax]
       test      r15,r15
       jne       near ptr M02_L32
       call      qword ptr [7FFC8DBBF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r8,rax
M02_L24:
       vmovaps   xmm0,xmm7
       mov       [rsp+0E0],r12
       xor       edx,edx
       mov       [rsp+0E8],edx
       mov       [rsp+0D0],r14
       mov       [rsp+0D8],r13d
       lea       rdx,[rsp+150]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+0E0]
       lea       r9,[rsp+0D0]
       call      qword ptr [7FFC8DE9CCA8]; System.Number.TryFormatDouble[[System.Char, System.Private.CoreLib]](Double, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo, System.Span`1<Char>, Int32 ByRef)
M02_L25:
       test      eax,eax
       je        near ptr M02_L82
       mov       r8d,[rsp+258]
       add       r8d,[rsp+150]
       mov       [rsp+258],r8d
M02_L26:
       xor       ecx,ecx
       mov       [rsp+158],rcx
       mov       ecx,[rsp+258]
       cmp       ecx,[rsp+268]
       ja        near ptr M02_L114
       mov       rax,[rsp+260]
       mov       [rsp+0E0],rax
       mov       [rsp+0E8],ecx
       lea       rcx,[rsp+0E0]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r14,rax
       mov       r12,[rsp+250]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+248],ymm0
       vmovdqu   xmmword ptr [rsp+260],xmm0
       test      r12,r12
       je        near ptr M02_L29
       mov       rcx,21B61401E70
       mov       r15,[rcx]
       mov       ecx,[r12+8]
       dec       ecx
       or        ecx,0F
       xor       r13d,r13d
       lzcnt     r13d,ecx
       xor       r13d,1F
       add       r13d,0FFFFFFFD
       mov       rcx,7FFC8D9C5120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L122
M02_L27:
       xor       eax,eax
       mov       dword ptr [rsp+148],1
       cmp       [rcx+8],r13d
       jbe       short M02_L28
       mov       dword ptr [rsp+14C],1
       mov       edx,10
       shlx      edx,edx,r13d
       cmp       [r12+8],edx
       jne       near ptr M02_L111
       cmp       r13d,[rcx+8]
       jae       near ptr M02_L213
       mov       edx,r13d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rsp+48],r10
       mov       r9,[r10]
       mov       [rsp+40],r9
       mov       rcx,r10
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+48]
       mov       [rdx+8],ecx
       mov       rax,[rsp+40]
       test      rax,rax
       mov       [rsp+40],rax
       mov       eax,[rsp+14C]
       jne       near ptr M02_L123
M02_L28:
       mov       rcx,21B614005D0
       mov       r10,[rcx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M02_L147
M02_L29:
       mov       rdx,r14
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L34
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       cmp       eax,[rcx+8]
       jae       near ptr M02_L213
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M02_L30:
       inc       ebp
       cmp       [rsi+8],ebp
       jg        near ptr M02_L03
M02_L31:
       mov       rdx,rdi
       mov       rcx,21B00200C60
       call      qword ptr [7FFC8DA86DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rdx,rax
       mov       rcx,21B002089D8
       mov       r8,21B002089F0
       call      qword ptr [7FFC8DA86B20]; System.String.Concat(System.String, System.String, System.String)
       nop
       vmovaps   xmm6,[rsp+280]
       vmovaps   xmm7,[rsp+270]
       add       rsp,298
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L32:
       mov       rdx,r15
       mov       rcx,offset MT_System.Globalization.CultureInfo
       call      qword ptr [7FFC8DA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L83
       cmp       byte ptr [rax+61],0
       jne       near ptr M02_L83
       mov       r8,[rax+18]
       test      r8,r8
       je        short M02_L36
M02_L33:
       jmp       near ptr M02_L24
M02_L34:
       mov       rcx,rdi
       call      qword ptr [7FFC8DB3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L30
M02_L35:
       cmp       dword ptr [rsp+208],1
       jne       short M02_L38
       jmp       near ptr M02_L88
M02_L36:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r8,rax
       jmp       short M02_L33
M02_L37:
       mov       rcx,rax
       mov       [rsp+0D0],r14
       mov       [rsp+0D8],r13d
       mov       [rsp+0E0],r12
       xor       edx,edx
       mov       [rsp+0E8],edx
       mov       rdx,[rsp+248]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+0D0]
       lea       r9,[rsp+0E0]
       lea       r8,[rsp+150]
       mov       r11,7FFC8D940620
       call      qword ptr [r11]
       jmp       near ptr M02_L25
M02_L38:
       mov       eax,[rsp+208]
       mov       [rsp+1F4],eax
       test      eax,eax
       jl        near ptr M02_L107
       mov       r8,[rsp+1F8]
       mov       [rsp+0A0],r8
       test      r8,r8
       je        near ptr M02_L211
       cmp       [r8+8],eax
       je        near ptr M02_L12
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+98],rax
       lea       rcx,[rax+10]
       mov       rdx,[rsp+0A0]
       lea       r10,[rdx+10]
       mov       edx,[rdx+8]
       mov       r9d,[rsp+1F4]
       cmp       r9d,edx
       jg        near ptr M02_L49
       mov       edx,r9d
M02_L39:
       mov       r8d,edx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M02_L10
       mov       rdx,r10
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L11
M02_L40:
       mov       [rsp+1D8],r12
       cmp       byte ptr [rsp+25C],0
       jne       near ptr M02_L180
       mov       rdx,[rsp+1D8]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC8DA84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L100
       mov       rdx,[rsp+1D8]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC8DA84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L42
M02_L41:
       mov       rdx,[rsp+1D8]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC8DA843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       ecx,[rsp+258]
       cmp       ecx,[rsp+268]
       ja        near ptr M02_L114
       mov       rdx,[rsp+260]
       mov       r9d,ecx
       lea       r15,[rdx+r9*2]
       mov       r14d,[rsp+268]
       sub       r14d,ecx
       xor       r12d,r12d
       mov       rcx,offset MT_System.Double
       cmp       [rax],rcx
       jne       near ptr M02_L63
       add       rax,8
       mov       rcx,[rsp+248]
       vmovsd    xmm6,qword ptr [rax]
       test      rcx,rcx
       je        near ptr M02_L98
       jmp       near ptr M02_L99
M02_L42:
       mov       rdx,[rsp+1D8]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC8DA843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rsp+248]
       mov       r11,7FFC8D940608
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
M02_L43:
       test      rdx,rdx
       je        short M02_L44
       mov       r8d,[rsp+258]
       cmp       r8d,[rsp+268]
       ja        near ptr M02_L114
       mov       rcx,[rsp+260]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+268]
       sub       eax,r8d
       mov       r13d,[rdx+8]
       cmp       r13d,eax
       ja        near ptr M02_L188
       add       rdx,0C
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFC8DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rsp+258]
       mov       [rsp+258],r13d
M02_L44:
       xor       ecx,ecx
       mov       [rsp+1D0],rcx
       mov       ecx,[rsp+258]
       cmp       ecx,[rsp+268]
       ja        near ptr M02_L114
       mov       rax,[rsp+260]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+268]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L189
       mov       rcx,21B00208784
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+258]
       inc       ecx
       mov       [rsp+258],ecx
M02_L45:
       mov       ecx,[rsp+258]
       cmp       ecx,[rsp+268]
       ja        near ptr M02_L114
       mov       rax,[rsp+260]
       mov       [rsp+0E0],rax
       mov       [rsp+0E8],ecx
       lea       rcx,[rsp+0E0]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r15,rax
       mov       r13,[rsp+250]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+248],ymm0
       vmovdqu   xmmword ptr [rsp+260],xmm0
       test      r13,r13
       je        near ptr M02_L48
       mov       rcx,21B61401E70
       mov       r12,[rcx]
       mov       ecx,[r13+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFC8D9C5120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L190
M02_L46:
       xor       eax,eax
       mov       dword ptr [rsp+1C0],1
       cmp       [rcx+8],r14d
       jbe       short M02_L47
       mov       dword ptr [rsp+1C4],1
       mov       edx,10
       shlx      edx,edx,r14d
       cmp       [r13+8],edx
       jne       near ptr M02_L109
       mov       edx,r14d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rsp+80],r10
       mov       r9,[r10]
       mov       [rsp+78],r9
       mov       rcx,r10
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+80]
       mov       [rdx+8],ecx
       mov       rax,[rsp+78]
       test      rax,rax
       mov       [rsp+78],rax
       mov       eax,[rsp+1C4]
       jne       near ptr M02_L191
M02_L47:
       mov       rcx,21B614005D0
       mov       r10,[rcx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M02_L205
M02_L48:
       mov       rdx,r15
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L62
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L30
M02_L49:
       jmp       near ptr M02_L39
M02_L50:
       mov       rdx,[rsp+160]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC8DA843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rsp+248]
       mov       r11,7FFC8D940618
       xor       edx,edx
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M02_L92
M02_L51:
       mov       r15,[r14+48]
       test      r15,r15
       je        near ptr M02_L126
       mov       rcx,r15
       call      qword ptr [7FFC8DB35050]; System.SpanHelpers.IndexOfNullByte(Byte*)
M02_L52:
       mov       r8,21B614009F0
       mov       r13,[r8]
       test      eax,eax
       jl        near ptr M02_L114
       test      eax,eax
       je        near ptr M02_L74
       mov       r10,r15
M02_L53:
       mov       [rsp+190],r10
       mov       r15,r10
       mov       [rsp+18C],eax
       test      r15,r15
       je        near ptr M02_L110
       lea       r8,[rsp+170]
       lea       r9,[rsp+168]
       mov       rcx,r15
       mov       edx,[rsp+18C]
       call      qword ptr [7FFC8DC27F48]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       sub       rax,r15
       mov       r9d,eax
       mov       eax,r9d
       add       eax,[rsp+170]
       mov       r8d,[rsp+18C]
       cmp       r9d,r8d
       jne       near ptr M02_L127
M02_L54:
       mov       [rsp+188],eax
       test      eax,eax
       je        near ptr M02_L128
       mov       ecx,eax
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+60],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       [rsp+180],rcx
       mov       rcx,r13
       mov       rdx,r15
       mov       r13d,[rsp+18C]
       mov       r8d,r13d
       mov       r9,[rsp+180]
       mov       r15d,[rsp+188]
       mov       [rsp+20],r15d
       call      qword ptr [7FFC8DC1A4D0]; System.Text.UTF8Encoding.GetChars(Byte*, Int32, Char*, Int32)
       xor       ecx,ecx
       mov       [rsp+180],rcx
       mov       r15,[rsp+60]
M02_L55:
       xor       ecx,ecx
       mov       [rsp+180],rcx
       mov       [rsp+190],rcx
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L19
M02_L56:
       xor       ecx,ecx
       mov       [rsp+248],rcx
       mov       rcx,21B61401E70
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFC8DC69EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+250],rax
       test      rax,rax
       je        near ptr M02_L174
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M02_L57:
       mov       [rsp+260],rdx
       mov       [rsp+268],eax
       xor       ecx,ecx
       mov       [rsp+258],ecx
       mov       byte ptr [rsp+25C],0
       mov       ecx,[rsp+258]
       cmp       ecx,[rsp+268]
       ja        near ptr M02_L114
       mov       rax,[rsp+260]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+268]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L175
       mov       rcx,21B00208784
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+258]
       inc       ecx
       mov       [rsp+258],ecx
M02_L58:
       cmp       r15,r13
       jne       near ptr M02_L177
       mov       r15,[r14+8]
       test      r15,r15
       je        near ptr M02_L72
M02_L59:
       cmp       byte ptr [rsp+25C],0
       jne       near ptr M02_L178
M02_L60:
       test      r15,r15
       je        near ptr M02_L178
       mov       r8d,[rsp+258]
       cmp       r8d,[rsp+268]
       ja        near ptr M02_L114
       mov       rcx,[rsp+260]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+268]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L178
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC8DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+258]
       add       edx,[r15+8]
       mov       [rsp+258],edx
M02_L61:
       mov       edx,[rsp+258]
       cmp       edx,[rsp+268]
       ja        near ptr M02_L114
       mov       rcx,[rsp+260]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+268]
       sub       eax,edx
       cmp       eax,3
       jb        near ptr M02_L179
       mov       rdx,21B002087EC
       mov       eax,[rdx]
       mov       r8d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r8d
       mov       edx,[rsp+258]
       add       edx,3
       mov       [rsp+258],edx
       jmp       near ptr M02_L40
M02_L62:
       mov       rcx,rdi
       call      qword ptr [7FFC8DB3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L30
M02_L63:
       mov       rcx,rax
       mov       [rsp+0D0],r15
       mov       [rsp+0D8],r14d
       mov       [rsp+0E0],r12
       xor       edx,edx
       mov       [rsp+0E8],edx
       mov       rdx,[rsp+248]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+0D0]
       lea       r9,[rsp+0E0]
       lea       r8,[rsp+1C8]
       mov       r11,7FFC8D940610
       call      qword ptr [r11]
M02_L64:
       test      eax,eax
       je        near ptr M02_L181
       mov       r8d,[rsp+258]
       add       r8d,[rsp+1C8]
       mov       [rsp+258],r8d
       jmp       near ptr M02_L44
M02_L65:
       vmovaps   xmm0,xmm6
       mov       [rsp+0E0],r12
       xor       edx,edx
       mov       [rsp+0E8],edx
       mov       [rsp+0D0],r15
       mov       [rsp+0D8],r14d
       lea       rdx,[rsp+1C8]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+0E0]
       lea       r9,[rsp+0D0]
       call      qword ptr [7FFC8DE9CCA8]; System.Number.TryFormatDouble[[System.Char, System.Private.CoreLib]](Double, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo, System.Span`1<Char>, Int32 ByRef)
       jmp       short M02_L64
M02_L66:
       mov       rax,[r12]
       add       rax,10
M02_L67:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M02_L68
       mov       rcx,21B61400438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M02_L68
       mov       rcx,21B61400418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M02_L154
M02_L68:
       mov       r12,rcx
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r12],rcx
       jne       near ptr M02_L97
       cmp       qword ptr [r12+10],0
       je        near ptr M02_L155
M02_L69:
       mov       rcx,[r12+10]
M02_L70:
       cmp       [rcx],cl
       test      r14,r14
       je        near ptr M02_L112
       mov       rdx,r14
       call      qword ptr [7FFC8DE96058]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
       mov       r14,rax
       test      r15,r15
       je        near ptr M02_L156
       cmp       dword ptr [r15+8],0
       je        near ptr M02_L156
       test      r14,r14
       je        near ptr M02_L157
       cmp       dword ptr [r14+8],0
       je        near ptr M02_L157
       mov       ecx,[r15+8]
       mov       eax,[r14+8]
       lea       rcx,[rcx+rax+3]
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L113
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       [r12],r12b
       lea       r8,[r12+0C]
       mov       rcx,21B00208784
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r12+0E]
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC8DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r15+8]
       inc       r8d
       movsxd    r8,r8d
       lea       r8,[r12+r8*2+0C]
       mov       rcx,21B0020880C
       mov       edx,[rcx]
       mov       [r8],edx
       mov       r8d,[r15+8]
       add       r8d,3
       movsxd    r8,r8d
       lea       rcx,[r12+r8*2+0C]
       lea       rdx,[r14+0C]
       mov       r8d,[r14+8]
       add       r8,r8
       call      qword ptr [7FFC8DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r12
M02_L71:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L87
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       cmp       eax,[rcx+8]
       jae       near ptr M02_L213
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L30
M02_L72:
       mov       r15,[r14+48]
       test      r15,r15
       je        near ptr M02_L176
       mov       rcx,r15
       call      qword ptr [7FFC8DB35050]; System.SpanHelpers.IndexOfNullByte(Byte*)
M02_L73:
       mov       [rsp+1E0],r15
       mov       [rsp+1E8],eax
       lea       rcx,[rsp+1E0]
       call      qword ptr [7FFC8DC86B98]; System.MdUtf8String.ToString()
       mov       r15,rax
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L59
M02_L74:
       mov       r10d,1
       jmp       near ptr M02_L53
M02_L75:
       mov       rdx,21B00203C30
       cmp       r8,rdx
       jne       near ptr M02_L158
       cmp       r15,r13
       jne       near ptr M02_L152
       mov       r15,[r14+8]
       test      r15,r15
       je        short M02_L78
M02_L76:
       mov       rdx,offset MT_System.Boolean
       cmp       [r12],rdx
       jne       near ptr M02_L153
       add       r12,8
       cmp       byte ptr [r12],0
       je        near ptr M02_L129
       mov       r14,21B00208A28
M02_L77:
       cmp       [r14],r14b
       mov       rdx,gs:[58]
       mov       rdx,[rdx+40]
       cmp       dword ptr [rdx+190],2
       jl        near ptr M02_L130
       mov       rdx,[rdx+198]
       mov       r12,[rdx+10]
       test      r12,r12
       je        near ptr M02_L130
       jmp       near ptr M02_L66
M02_L78:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+110],xmm0
       mov       rdx,[r14+48]
       lea       rcx,[rsp+110]
       call      qword ptr [7FFC8DC86B20]
       vmovups   xmm0,[rsp+110]
       vmovups   [rsp+100],xmm0
       lea       rcx,[rsp+100]
       call      qword ptr [7FFC8DC86B98]; System.MdUtf8String.ToString()
       mov       r15,rax
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L76
M02_L79:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       cmp       byte ptr [rsp+25C],0
       je        near ptr M02_L20
M02_L80:
       lea       rcx,[rsp+248]
       mov       rdx,r15
       call      qword ptr [7FFC8DBB5848]
       jmp       near ptr M02_L21
M02_L81:
       lea       rcx,[rsp+248]
       mov       rdx,21B00208800
       call      qword ptr [7FFC8DBB58F0]
       jmp       near ptr M02_L22
M02_L82:
       lea       rcx,[rsp+248]
       call      qword ptr [7FFC8DBB5938]
       jmp       near ptr M02_L23
M02_L83:
       mov       r8,r15
       mov       rax,offset MT_System.Globalization.NumberFormatInfo
       cmp       [r8],rax
       jne       short M02_L86
M02_L84:
       test      r8,r8
       je        near ptr M02_L131
M02_L85:
       jmp       near ptr M02_L33
M02_L86:
       xor       r8d,r8d
       jmp       short M02_L84
M02_L87:
       mov       rcx,rdi
       call      qword ptr [7FFC8DB3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L30
M02_L88:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+0A8],rax
       mov       rcx,rax
       mov       r8,[rsp+200]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rsp+0A8]
       jmp       near ptr M02_L13
M02_L89:
       xor       r8d,r8d
       mov       [rsp+158],r8
       lea       r8,[rsp+160]
       cmp       qword ptr [rsp+158],0
       jne       short M02_L90
       mov       r8,[r8]
       mov       [rsp+158],r8
       lea       r8,[rsp+158]
       cmp       qword ptr [rsp+158],0
       je        near ptr M02_L132
M02_L90:
       mov       rcx,[r8]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M02_L133
       cmp       [rcx],cl
M02_L91:
       mov       r15,rcx
M02_L92:
       test      r15,r15
       je        near ptr M02_L26
       mov       r8d,[rsp+258]
       cmp       r8d,[rsp+268]
       ja        near ptr M02_L114
       mov       rcx,[rsp+260]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+268]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L134
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC8DB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+258]
       add       ecx,[r15+8]
       mov       [rsp+258],ecx
       jmp       near ptr M02_L26
M02_L93:
       mov       rax,[rax]
       add       rax,10
M02_L94:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M02_L95
       mov       rcx,21B61400438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M02_L95
       mov       rcx,21B61400418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M02_L183
M02_L95:
       cmp       byte ptr [rcx+61],0
       jne       near ptr M02_L184
M02_L96:
       mov       r8,[rcx+18]
       test      r8,r8
       je        near ptr M02_L184
       jmp       near ptr M02_L65
M02_L97:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M02_L70
M02_L98:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M02_L182
       mov       rcx,[rcx+198]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M02_L182
       jmp       near ptr M02_L93
M02_L99:
       call      qword ptr [7FFC8DBBF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r8,rax
       jmp       near ptr M02_L65
M02_L100:
       xor       r8d,r8d
       mov       [rsp+1D0],r8
       lea       r8,[rsp+1D8]
       cmp       qword ptr [rsp+1D0],0
       jne       short M02_L101
       mov       r8,[r8]
       mov       [rsp+1D0],r8
       lea       r8,[rsp+1D0]
       cmp       qword ptr [rsp+1D0],0
       je        near ptr M02_L186
M02_L101:
       mov       rcx,[r8]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M02_L187
M02_L102:
       mov       rdx,rcx
M02_L103:
       jmp       near ptr M02_L43
M02_L104:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,21B00208778
       mov       r8,21B00208790
       call      qword ptr [7FFC8DA86B20]; System.String.Concat(System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M02_L105
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       edx,edx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L30
M02_L105:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC8DB3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L30
M02_L106:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC8DECE898]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC8DA8F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L107:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFC8DC2ED48]
       int       3
M02_L108:
       mov       rdx,rax
       call      qword ptr [7FFC8DA843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M02_L109:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC8DF052D8]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFC8D934000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC8DA8F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L110:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFC8DC2ED18]
       int       3
M02_L111:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC8DF052D8]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFC8D934000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC8DA8F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L112:
       mov       ecx,16EB
       mov       rdx,7FFC8D934000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC8DC566E8]
       int       3
M02_L113:
       call      qword ptr [7FFC8DC2EF40]
       int       3
M02_L114:
       call      qword ptr [7FFC8DC2E9D0]
       int       3
M02_L115:
       mov       rcx,21B61401E88
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L02
M02_L116:
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[r15+58]
       call      qword ptr [rax+38]
       mov       r12,rax
       jmp       near ptr M02_L06
M02_L117:
       mov       rcx,rax
       mov       rdx,[rax]
       mov       rdx,[rdx+98]
       call      qword ptr [rdx+20]
       mov       rcx,21B002021B8
       cmp       rax,rcx
       jne       near ptr M02_L15
M02_L118:
       mov       rcx,[rsp+0C0]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L15
       mov       rcx,[rsp+0C0]
       mov       rdx,r12
       call      qword ptr [7FFC8DE95EF0]
       mov       r13,rax
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       r9,r13
       mov       rcx,21B00208778
       mov       r8,21B00208800
       call      qword ptr [7FFC8DA86B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L119
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L30
M02_L119:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC8DB3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L30
M02_L120:
       xor       edx,edx
       xor       eax,eax
       jmp       near ptr M02_L17
M02_L121:
       lea       rcx,[rsp+248]
       mov       rdx,21B00208778
       call      qword ptr [7FFC8DBB58F0]
       jmp       near ptr M02_L18
M02_L122:
       mov       rcx,r15
       call      qword ptr [7FFC8DC5D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L27
M02_L123:
       mov       rcx,[r15+10]
       cmp       r13d,[rcx+8]
       jae       near ptr M02_L213
       mov       edx,r13d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rsp+14C],eax
       jne       short M02_L124
       mov       rcx,r15
       mov       edx,r13d
       call      qword ptr [7FFC8DC5D7E8]
       mov       r10,rax
M02_L124:
       mov       r10,[r10+8]
       mov       [rsp+38],r10
       mov       rcx,7FFC8D9C5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFC8D9C5C38],0
       je        near ptr M02_L135
       call      qword ptr [7FFC8DA8DC98]
       mov       edx,eax
       mov       [rsp+130],edx
       jmp       near ptr M02_L138
M02_L125:
       lea       rcx,[rsp+248]
       mov       r8,[rsp+160]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFC8E09F0F0]
       jmp       near ptr M02_L26
M02_L126:
       xor       eax,eax
       jmp       near ptr M02_L52
M02_L127:
       mov       [rsp+17C],eax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8d,[rsp+18C]
       call      qword ptr [7FFC8DA8C990]
       add       eax,[rsp+17C]
       mov       ecx,eax
       test      ecx,ecx
       mov       eax,ecx
       jge       near ptr M02_L54
       call      qword ptr [7FFC8DA8C7E0]
       int       3
M02_L128:
       mov       r15,21B00200008
       jmp       near ptr M02_L55
M02_L129:
       mov       r14,21B00208A08
       jmp       near ptr M02_L77
M02_L130:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M02_L67
M02_L131:
       mov       rcx,r15
       mov       r11,7FFC8D940628
       mov       rdx,21B002019C8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      qword ptr [7FFC8DA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r8,rax
       test      r8,r8
       jne       near ptr M02_L85
       call      qword ptr [7FFC8DBBF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r8,rax
       jmp       near ptr M02_L85
M02_L132:
       xor       r15d,r15d
       jmp       near ptr M02_L92
M02_L133:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L91
M02_L134:
       lea       rcx,[rsp+248]
       mov       rdx,r15
       call      qword ptr [7FFC8DBB58F0]
       jmp       near ptr M02_L26
M02_L135:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rsp+12C],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rsp+12C]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L136
       call      qword ptr [7FFC8E09C4C8]
       mov       edx,eax
       jmp       short M02_L137
M02_L136:
       mov       edx,ecx
       sar       edx,10
M02_L137:
       mov       [rsp+130],edx
M02_L138:
       mov       rcx,7FFC8D9C5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rsp+130]
       xor       edx,edx
       div       dword ptr [7FFC8D9C5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L145
M02_L139:
       cmp       eax,[r8+8]
       jae       near ptr M02_L213
       mov       [rsp+138],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+30],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+128],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rsp+124],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L141
       test      r10d,r10d
       jne       short M02_L142
       xor       edx,edx
       mov       [rax+14],edx
M02_L140:
       movsxd    rdx,r10d
       mov       r8,[rsp+40]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+124]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+128],1
M02_L141:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rsp+128]
       test      ecx,ecx
       je        short M02_L143
       mov       r8d,1
       jmp       short M02_L146
M02_L142:
       jmp       short M02_L140
M02_L143:
       mov       eax,[rsp+138]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rsp+38]
       cmp       [rcx+8],r8d
       jne       short M02_L144
       xor       r8d,r8d
M02_L144:
       mov       edx,[rsp+134]
       inc       edx
       mov       eax,r8d
M02_L145:
       mov       r8,[rsp+38]
       mov       [rsp+134],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L139
       xor       r8d,r8d
M02_L146:
       mov       eax,r8d
       mov       [rsp+148],eax
       mov       eax,[rsp+14C]
       jmp       near ptr M02_L28
M02_L147:
       mov       edx,eax
       mov       r8,r10
       mov       eax,[rsp+148]
       cmp       dword ptr [r12+8],0
       mov       [rsp+14C],edx
       mov       [rsp+58],r8
       mov       [rsp+148],eax
       je        near ptr M02_L29
       cmp       [r12],r12b
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+144],eax
       mov       edx,[r12+8]
       mov       [rsp+140],edx
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+58]
       mov       r8d,[rsp+144]
       mov       r9d,[rsp+140]
       mov       edx,3
       call      qword ptr [7FFC8DB37690]
       mov       eax,[rsp+14C]
       test      [rsp+148],eax
       mov       [rsp+14C],eax
       jne       near ptr M02_L29
       cmp       [r12],r12b
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[r12+8]
       mov       rdx,[rsp+58]
       mov       [rsp+50],rdx
       mov       [rsp+13C],eax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[rsp+14C]
       test      r15d,r15d
       jne       short M02_L148
       mov       r13,[rsp+50]
       mov       edx,[rsp+13C]
       mov       ecx,0FFFFFFFF
       jmp       short M02_L149
M02_L148:
       mov       rdx,[rsp+50]
       mov       ecx,[rsp+13C]
       mov       r8d,ecx
       mov       ecx,r13d
       mov       r13,rdx
       mov       edx,r8d
M02_L149:
       mov       r8d,r12d
       mov       r9d,eax
       test      r15d,r15d
       jne       short M02_L150
       mov       eax,1
       jmp       short M02_L151
M02_L150:
       xor       eax,eax
M02_L151:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r13
       call      qword ptr [7FFC8DC5E2B0]
       jmp       near ptr M02_L29
M02_L152:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r15,rax
M02_L153:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M02_L77
M02_L154:
       call      qword ptr [7FFC8DBD4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M02_L68
M02_L155:
       mov       rcx,offset MT_System.Globalization.TextInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,[r12+30]
       mov       rcx,r13
       call      qword ptr [7FFC8DBDC018]; System.Globalization.TextInfo..ctor(System.Globalization.CultureData)
       movzx     ecx,byte ptr [r12+60]
       mov       [r13+30],cl
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L69
M02_L156:
       mov       r8,r14
       mov       rcx,21B00208778
       mov       rdx,21B00208800
       call      qword ptr [7FFC8DA86B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L71
M02_L157:
       mov       rdx,r15
       mov       rcx,21B00208778
       mov       r8,21B00208800
       call      qword ptr [7FFC8DA86B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L71
M02_L158:
       mov       rdx,21B002089B0
       cmp       r8,rdx
       jne       near ptr M02_L166
       mov       rdx,r12
       mov       rcx,offset MT_System.DateTime
       call      qword ptr [7FFC8DA84408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rcx,[rax]
       mov       r8,21B61400428
       mov       r8,[r8]
       mov       rdx,21B00206808
       call      qword ptr [7FFC8E185020]
       mov       r12,rax
       lea       rcx,[rsp+248]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFC8DBB56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+258]
       cmp       ecx,[rsp+268]
       ja        near ptr M02_L114
       mov       rdx,[rsp+260]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+268]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L159
       mov       rcx,21B00208784
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rsp+258]
       inc       ecx
       mov       [rsp+258],ecx
       jmp       short M02_L160
M02_L159:
       lea       rcx,[rsp+248]
       mov       rdx,21B00208778
       call      qword ptr [7FFC8DBB58F0]
M02_L160:
       mov       rcx,r14
       mov       r15,[r14]
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rsp+248]
       call      qword ptr [7FFC8DBB5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+258]
       cmp       ecx,[rsp+268]
       ja        near ptr M02_L114
       mov       rdx,[rsp+260]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+268]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L161
       mov       rcx,21B002087EC
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rsp+258]
       add       ecx,3
       mov       [rsp+258],ecx
       jmp       short M02_L162
M02_L161:
       lea       rcx,[rsp+248]
       mov       rdx,21B002087E0
       call      qword ptr [7FFC8DBB58F0]
M02_L162:
       lea       rcx,[rsp+248]
       mov       rdx,r12
       call      qword ptr [7FFC8DBB5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+258]
       cmp       ecx,[rsp+268]
       ja        near ptr M02_L114
       mov       rdx,[rsp+260]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+268]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L163
       mov       rcx,21B00208784
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rsp+258]
       inc       ecx
       mov       [rsp+258],ecx
       jmp       short M02_L164
M02_L163:
       lea       rcx,[rsp+248]
       mov       rdx,21B00208778
       call      qword ptr [7FFC8DBB58F0]
M02_L164:
       lea       rcx,[rsp+248]
       call      qword ptr [7FFC8DBB5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L165
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       cmp       edx,[rcx+8]
       jae       near ptr M02_L213
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L30
M02_L165:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC8DB3E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L30
M02_L166:
       lea       rcx,[rsp+248]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFC8DBB56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+258]
       cmp       ecx,[rsp+268]
       ja        near ptr M02_L114
       mov       rdx,[rsp+260]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+268]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L167
       mov       rcx,21B00208784
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rsp+258]
       inc       ecx
       mov       [rsp+258],ecx
       jmp       short M02_L168
M02_L167:
       lea       rcx,[rsp+248]
       mov       rdx,21B00208778
       call      qword ptr [7FFC8DBB58F0]
M02_L168:
       mov       rcx,r14
       mov       r15,[r14]
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rsp+248]
       call      qword ptr [7FFC8DBB5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+258]
       cmp       ecx,[rsp+268]
       ja        near ptr M02_L114
       mov       rdx,[rsp+260]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+268]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L169
       mov       rcx,21B002087EC
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rsp+258]
       add       ecx,3
       mov       [rsp+258],ecx
       jmp       short M02_L170
M02_L169:
       lea       rcx,[rsp+248]
       mov       rdx,21B002087E0
       call      qword ptr [7FFC8DBB58F0]
M02_L170:
       lea       rcx,[rsp+248]
       mov       r8,r12
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFC8DD17978]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       r14d,[rsp+258]
       cmp       r14d,[rsp+268]
       jbe       short M02_L171
       call      qword ptr [7FFC8DC2E9D0]
M02_L171:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0F0],xmm0
       mov       rdx,[rsp+260]
       mov       r8d,r14d
       lea       rdx,[rdx+r8*2]
       mov       r8d,[rsp+268]
       sub       r8d,r14d
       lea       rcx,[rsp+0F0]
       call      qword ptr [7FFC8DB3FCC0]
       vmovdqu   xmm0,xmmword ptr [rsp+0F0]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       lea       rdx,[rsp+0D0]
       mov       rcx,21B00208778
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DA86628]
       test      eax,eax
       je        short M02_L172
       mov       ecx,[rsp+258]
       inc       ecx
       mov       [rsp+258],ecx
       jmp       short M02_L173
M02_L172:
       lea       rcx,[rsp+248]
       mov       rdx,21B00208778
       call      qword ptr [7FFC8DBB58F0]
M02_L173:
       lea       rcx,[rsp+248]
       call      qword ptr [7FFC8DBB5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC8DB564B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M02_L30
M02_L174:
       xor       edx,edx
       xor       eax,eax
       jmp       near ptr M02_L57
M02_L175:
       lea       rcx,[rsp+248]
       mov       rdx,21B00208778
       call      qword ptr [7FFC8DBB58F0]
       jmp       near ptr M02_L58
M02_L176:
       xor       eax,eax
       jmp       near ptr M02_L73
M02_L177:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       cmp       byte ptr [rsp+25C],0
       je        near ptr M02_L60
M02_L178:
       lea       rcx,[rsp+248]
       mov       rdx,r15
       call      qword ptr [7FFC8DBB5848]
       jmp       near ptr M02_L61
M02_L179:
       lea       rcx,[rsp+248]
       mov       rdx,21B002087E0
       call      qword ptr [7FFC8DBB58F0]
       jmp       near ptr M02_L40
M02_L180:
       lea       rcx,[rsp+248]
       mov       r8,[rsp+1D8]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFC8E09F0F0]
       jmp       near ptr M02_L44
M02_L181:
       lea       rcx,[rsp+248]
       call      qword ptr [7FFC8DBB5938]
       jmp       near ptr M02_L41
M02_L182:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M02_L94
M02_L183:
       call      qword ptr [7FFC8DBD4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       cmp       byte ptr [rcx+61],0
       je        near ptr M02_L96
M02_L184:
       mov       rdx,21B002019C8
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       r8,rax
       test      r8,r8
       je        short M02_L185
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       cmp       [r8],rcx
       jne       near ptr M02_L108
M02_L185:
       jmp       near ptr M02_L65
M02_L186:
       xor       edx,edx
       jmp       near ptr M02_L103
M02_L187:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L102
M02_L188:
       lea       rcx,[rsp+248]
       call      qword ptr [7FFC8DBB58F0]
       jmp       near ptr M02_L44
M02_L189:
       lea       rcx,[rsp+248]
       mov       rdx,21B00208778
       call      qword ptr [7FFC8DBB58F0]
       jmp       near ptr M02_L45
M02_L190:
       mov       rcx,r12
       call      qword ptr [7FFC8DC5D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L46
M02_L191:
       mov       rcx,[r12+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M02_L213
       mov       edx,r14d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rsp+1C4],eax
       jne       short M02_L192
       mov       rcx,r12
       mov       edx,r14d
       call      qword ptr [7FFC8DC5D7E8]
       mov       r10,rax
M02_L192:
       mov       r10,[r10+8]
       mov       [rsp+70],r10
       mov       rcx,7FFC8D9C5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFC8D9C5C38],0
       je        short M02_L193
       call      qword ptr [7FFC8DA8DC98]
       mov       edx,eax
       mov       [rsp+1A8],edx
       jmp       short M02_L196
M02_L193:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rsp+1A4],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rsp+1A4]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L194
       call      qword ptr [7FFC8E09C4C8]
       mov       edx,eax
       jmp       short M02_L195
M02_L194:
       mov       edx,ecx
       sar       edx,10
M02_L195:
       mov       [rsp+1A8],edx
M02_L196:
       mov       rcx,7FFC8D9C5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rsp+1A8]
       xor       edx,edx
       div       dword ptr [7FFC8D9C5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L203
M02_L197:
       cmp       eax,[r8+8]
       jae       near ptr M02_L213
       mov       [rsp+1B0],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+68],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+1A0],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+68]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rsp+19C],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L199
       test      r10d,r10d
       jne       short M02_L200
       xor       edx,edx
       mov       [rax+14],edx
M02_L198:
       movsxd    rdx,r10d
       mov       r8,[rsp+78]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+19C]
       inc       ecx
       mov       rax,[rsp+68]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+1A0],1
M02_L199:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rsp+1A0]
       test      ecx,ecx
       je        short M02_L201
       mov       r8d,1
       jmp       short M02_L204
M02_L200:
       jmp       short M02_L198
M02_L201:
       mov       eax,[rsp+1B0]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rsp+70]
       cmp       [rcx+8],r8d
       jne       short M02_L202
       xor       r8d,r8d
M02_L202:
       mov       edx,[rsp+1AC]
       inc       edx
       mov       eax,r8d
M02_L203:
       mov       r8,[rsp+70]
       mov       [rsp+1AC],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L197
       xor       r8d,r8d
M02_L204:
       mov       eax,r8d
       mov       [rsp+1C0],eax
       mov       eax,[rsp+1C4]
       jmp       near ptr M02_L47
M02_L205:
       mov       edx,eax
       mov       r8,r10
       mov       eax,[rsp+1C0]
       cmp       dword ptr [r13+8],0
       mov       [rsp+1C4],edx
       mov       [rsp+90],r8
       mov       [rsp+1C0],eax
       je        near ptr M02_L48
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+1BC],eax
       mov       edx,[r13+8]
       mov       [rsp+1B8],edx
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+90]
       mov       r8d,[rsp+1BC]
       mov       r9d,[rsp+1B8]
       mov       edx,3
       call      qword ptr [7FFC8DB37690]
       mov       eax,[rsp+1C4]
       test      [rsp+1C0],eax
       mov       [rsp+1C4],eax
       jne       near ptr M02_L48
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[r13+8]
       mov       rdx,[rsp+90]
       mov       [rsp+88],rdx
       mov       [rsp+1B4],eax
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[rsp+1C4]
       test      r12d,r12d
       jne       short M02_L206
       mov       r14,[rsp+88]
       mov       edx,[rsp+1B4]
       mov       ecx,0FFFFFFFF
       jmp       short M02_L207
M02_L206:
       mov       rdx,[rsp+88]
       mov       ecx,[rsp+1B4]
       mov       r8d,ecx
       mov       ecx,r14d
       mov       r14,rdx
       mov       edx,r8d
M02_L207:
       mov       r8d,r13d
       mov       r9d,eax
       test      r12d,r12d
       jne       short M02_L208
       mov       eax,1
       jmp       short M02_L209
M02_L208:
       xor       eax,eax
M02_L209:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFC8DC5E2B0]
       jmp       near ptr M02_L48
M02_L210:
       mov       rcx,r14
       mov       rax,[r15+50]
       call      qword ptr [rax+10]
       mov       rdx,rax
       mov       rax,rdx
       jmp       near ptr M02_L08
M02_L211:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+1F8],rax
       jmp       near ptr M02_L12
M02_L212:
       mov       rcx,r10
       mov       edx,1C
       mov       rax,[r10]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rcx
       jmp       near ptr M02_L14
M02_L213:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 9787
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M03_L04
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M03_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M03_L00
       test      dl,4
       jne       short M03_L03
M03_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M03_L02:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M03_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M03_L01
M03_L04:
       cmp       edx,4
       jae       short M03_L03
       mov       eax,80
       test      dl,1
       je        short M03_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M03_L05:
       test      dl,2
       mov       edx,eax
       je        short M03_L02
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       near ptr M03_L02
; Total bytes of code 266
```
**Extern method**
System.Object.GetType()
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SerializationBenchmarks.NewtonsoftValueLoopMapping()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+0C],0
       jle       near ptr M00_L03
       mov       rdi,1E3B6404188
M00_L00:
       mov       rbp,[rdi]
       mov       rcx,1E3B6404E68
       mov       rax,[rcx]
       test      rax,rax
       jne       short M00_L04
       xor       r14d,r14d
M00_L01:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFC8DE96CD0]; Newtonsoft.Json.JsonSerializer..ctor()
       test      r14,r14
       jne       short M00_L05
M00_L02:
       mov       rcx,rbp
       mov       r8,r15
       xor       edx,edx
       call      qword ptr [7FFC8DE94738]; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       mov       rcx,rax
       mov       r14d,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,0AA1913B3
       mov       r9d,5A115C74
       call      qword ptr [7FFC8E015F68]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,r14d
       mov       [rbx+8],eax
       inc       esi
       cmp       esi,[rbx+0C]
       jl        short M00_L00
M00_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       short M00_L01
M00_L05:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFC8DE96D48]
       jmp       short M00_L02
; Total bytes of code 193
```
```assembly
; Newtonsoft.Json.JsonSerializer..ctor()
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       xor       eax,eax
       mov       [rbx+5C],eax
       mov       [rbx+60],eax
       mov       [rbx+68],eax
       mov       [rbx+6C],eax
       mov       [rbx+64],eax
       mov       [rbx+58],eax
       mov       [rbx+70],eax
       mov       [rbx+50],eax
       mov       [rbx+74],eax
       mov       rax,1E3B6404EB0
       mov       rsi,[rax]
       add       rsi,8
       lea       rdi,[rbx+80]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       rcx,1E3B64050A8
       mov       rdx,[rcx]
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1E3B6404EB8
       mov       rdx,[rcx]
       lea       rcx,[rbx+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1E3B6405090
       mov       rdx,[rcx]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edx,100
       mov       dword ptr [r14+20],7FFFFFFF
       cmp       edx,400
       jl        near ptr M02_L04
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M02_L00:
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1E3B6400428
       mov       r13,[rcx]
       mov       rcx,1E3B64014E8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1E380301C08
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],1
       mov       [rbp-38],r15
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       [r14+24],ecx
       mov       dword ptr [r14+2C],3
       mov       byte ptr [r14+38],1
       mov       byte ptr [r14+39],1
       lea       rcx,[r14+58]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       word ptr [r14+8E],22
       mov       byte ptr [r14+91],1
       mov       word ptr [r14+8C],20
       mov       dword ptr [r14+88],2
       mov       ecx,[r14+30]
       mov       rdx,1E3B6405058
       mov       rax,1E3B6405060
       cmp       ecx,2
       mov       rdx,[rdx]
       cmove     rdx,[rax]
       lea       rcx,[r14+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],1
       mov       [rbp-40],r14
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       r13d,[rbx+94]
       jmp       short M02_L03
M02_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFC8DE8ADD0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC8DB4D458]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       r13d,eax
M02_L03:
       test      r13d,r13d
       jl        short M02_L01
       cmp       r13d,1
       jg        short M02_L01
       mov       [r14+24],r13d
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rax,[rbx]
       mov       rax,[rax+80]
       call      qword ptr [rax+18]
       nop
       mov       rcx,rsp
       call      M02_L05
       nop
       mov       r15,[rbp-38]
       mov       rcx,[r15+20]
       cmp       [rcx],ecx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFC8DCD9968]; System.Text.StringBuilder.ToString()
M02_L04:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M02_L00
M02_L05:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       r14,[rbp-40]
       cmp       dword ptr [r14+20],8
       je        near ptr M02_L15
       cmp       byte ptr [r14+39],0
       je        short M02_L11
       jmp       short M02_L07
M02_L06:
       mov       edx,[r14+48]
       mov       rcx,r14
       call      qword ptr [7FFC8DE9EDF0]
M02_L07:
       mov       rax,[r14+8]
       test      rax,rax
       jne       short M02_L08
       xor       r15d,r15d
       jmp       short M02_L09
M02_L08:
       mov       ecx,[rax+10]
       mov       r15d,ecx
M02_L09:
       cmp       dword ptr [r14+48],0
       je        short M02_L10
       inc       r15d
M02_L10:
       test      r15d,r15d
       jg        short M02_L06
M02_L11:
       mov       rdx,[r14+70]
       test      rdx,rdx
       je        short M02_L13
       mov       rcx,[r14+78]
       test      rcx,rcx
       je        short M02_L12
       mov       r11,7FFC8D950CD0
       call      qword ptr [r11]
M02_L12:
       xor       ecx,ecx
       mov       [r14+70],rcx
M02_L13:
       cmp       byte ptr [r14+38],0
       je        short M02_L15
       mov       rcx,[r14+58]
       test      rcx,rcx
       je        short M02_L15
       mov       rax,offset MT_System.IO.StringWriter
       cmp       [rcx],rax
       jne       short M02_L14
       mov       byte ptr [rcx+28],0
       jmp       short M02_L15
M02_L14:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
M02_L15:
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 774
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M03_L04
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M03_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M03_L00
       test      dl,4
       je        short M03_L02
M03_L01:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
M03_L02:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M03_L03:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M03_L04:
       cmp       edx,4
       jae       short M03_L01
       mov       eax,80
       test      dl,1
       je        short M03_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M03_L05:
       test      dl,2
       mov       edx,eax
       je        short M03_L03
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       short M03_L03
; Total bytes of code 261
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SerializationBenchmarks.TextJsonValueLoopMapping()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       xor       esi,esi
       cmp       dword ptr [rbx+0C],0
       jle       near ptr M00_L04
M00_L00:
       mov       rdx,206B3804188
       mov       rdx,[rdx]
       mov       [rsp+40],rdx
       mov       rdx,206B3804F28
       mov       rdi,[rdx]
       test      rdi,rdi
       je        near ptr M00_L06
       cmp       byte ptr [rdi+9E],0
       je        near ptr M00_L07
M00_L01:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        near ptr M00_L08
       mov       rdx,[rbp+0B8]
       mov       r8,20680208750
       cmp       rdx,r8
       jne       near ptr M00_L08
M00_L02:
       mov       rdx,rbp
       mov       r8,rdx
       test      r8,r8
       je        short M00_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       short M00_L05
M00_L03:
       lea       rdx,[rsp+40]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]](Ferris.Json.Test.TestObjects.ValueTestObject ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.ValueTestObject>)
       call      qword ptr [7FFC8DEB6FD0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rcx,rax
       mov       edi,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,20DF6D99
       mov       r9d,0B837C76
       call      qword ptr [7FFC8DF75140]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,edi
       mov       [rbx+8],eax
       inc       esi
       cmp       esi,[rbx+0C]
       jl        near ptr M00_L00
M00_L04:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      qword ptr [7FFC8DAB43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L06:
       mov       rcx,206B3804F28
       xor       edx,edx
       call      qword ptr [7FFC8DEB5AB8]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       mov       rdi,rax
       cmp       byte ptr [rdi+9E],0
       jne       near ptr M00_L01
M00_L07:
       mov       rcx,rdi
       call      qword ptr [7FFC8DEB5A10]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L08:
       mov       byte ptr [rsp+38],1
       mov       byte ptr [rsp+39],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       movzx     r9d,word ptr [rsp+38]
       mov       rdx,20680208750
       mov       r8d,1
       call      qword ptr [7FFC8DEB52C0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
; Total bytes of code 353
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DEB5A88]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M01_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M01_L12
M01_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M01_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,206B3801F80
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFC8E098018]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M01_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M01_L02
M01_L01:
       mov       edx,2
M01_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M01_L13
       mov       rdi,20680201C08
M01_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M01_L14
M01_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFC8DEB6D90]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M01_L08
       cmp       [rcx+8],r15d
       jb        short M01_L07
M01_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M01_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M01_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M01_L06:
       mov       ecx,r15d
       mov       eax,r12d
       cmp       rcx,rax
       ja        short M01_L07
       mov       r12d,r15d
       jmp       short M01_L10
M01_L07:
       call      qword ptr [7FFC8DC4E9D0]
       int       3
M01_L08:
       test      r15d,r15d
       jne       short M01_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M01_L05
M01_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M01_L06
M01_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFC8DEBD908]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M01_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M01_L00
M01_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFC8E08D1E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L13:
       mov       rcx,7FFC8DEAC840
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,206B3804F68
       mov       rdi,[rcx]
       jmp       near ptr M01_L03
M01_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFC8E086748]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M01_L04
M01_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFC8E08CCF0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFC8E0868C8]
       mov       r14,r13
       jmp       near ptr M01_L04
M01_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        short M01_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M01_L18
M01_L17:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M01_L19
M01_L18:
       mov       rax,[rcx]
       add       rax,10
M01_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M01_L20
       test      r10d,r10d
       jne       short M01_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M01_L23
M01_L20:
       cmp       [rcx+8],r10d
       jae       short M01_L22
M01_L21:
       call      qword ptr [7FFC8DC4E9D0]
       int       3
M01_L22:
       add       rcx,10
M01_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M01_L25
       cmp       rdx,300
       ja        short M01_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M01_L25
M01_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFC8DB65BA8]
M01_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,206B3801F80
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC8E098020]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1184
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M02_L04
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M02_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M02_L00
       test      dl,4
       je        short M02_L02
M02_L01:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
M02_L02:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M02_L03:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M02_L04:
       cmp       edx,4
       jae       short M02_L01
       mov       eax,80
       test      dl,1
       je        short M02_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M02_L05:
       test      dl,2
       mov       edx,eax
       je        short M02_L03
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       short M02_L03
; Total bytes of code 261
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M03_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M03_L02
M03_L01:
       mov       rax,rdx
       ret
M03_L02:
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L01
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L01
       test      rax,rax
       je        short M03_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L01
       test      rax,rax
       jne       short M03_L00
M03_L03:
       lea       rax,[7FFCEAE1B908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       edx,[rbp+18]
       call      qword ptr [7FFC8DEB5440]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerDefaults)
       mov       rax,[rbp-18]
       mov       [rbp-20],rax
       mov       rax,[rbp-18]
       mov       [rbp-28],rax
       call      qword ptr [7FFC8DEB4828]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       jne       short M04_L00
       mov       rax,[rbp-20]
       mov       [rbp-30],rax
       mov       rax,[rbp-28]
       mov       [rbp-38],rax
       call      qword ptr [7FFC8DEB76F0]
       mov       [rbp-40],rax
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFC8DEB75E8]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-10],rax
       mov       rcx,[rbp-20]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-28]
       mov       [rbp-38],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-40],rcx
M04_L01:
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DEB54A0]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       r8,[rbp-30]
       mov       byte ptr [r8+9D],1
       mov       r8,[rbp-30]
       mov       [rbp-8],r8
       mov       r8,[rbp-8]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_System.Threading.Interlocked.CompareExchange[[System.Text.Json.JsonSerializerOptions, System.Text.Json]](System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.JsonSerializerOptions)
       xor       r9d,r9d
       call      qword ptr [7FFC8DEB7678]; System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       mov       [rbp-48],rax
       mov       rax,[rbp-48]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-48],0
       jne       short M04_L02
       mov       rax,[rbp-8]
       mov       [rbp-50],rax
M04_L02:
       mov       rax,[rbp-50]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M05_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M05_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M05_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFC8DEB4828]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M05_L05
       call      qword ptr [7FFC8DEB75E8]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M05_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFC8DAB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M05_L03
       jmp       near ptr M05_L09
M05_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L09
M05_L03:
       call      qword ptr [7FFC8DEB77F8]
       test      eax,eax
       je        near ptr M05_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFC8DF74450]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFC8DF74450]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFC8DF74480]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC8DEB76C0]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M05_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DF74318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M05_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DF74318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M05_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DF74318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DEB5A10]
       jmp       short M05_L09
M05_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DF74390]
       jmp       short M05_L09
M05_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M05_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFC8DAB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M05_L07
M05_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M05_L08
M05_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M05_L08:
       cmp       dword ptr [rbp-34],0
       je        short M05_L09
       call      qword ptr [7FFC8DEBC978]
M05_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       xor       ecx,ecx
       mov       [rbp-8],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC8DEB59C8]; System.Text.Json.JsonSerializerOptions.get_IsReadOnly()
       test      eax,eax
       je        short M06_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC8DEB5278]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DF74360]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddTypeInfo(System.Type, Boolean)
       mov       [rbp-8],rax
       mov       ecx,[rbp+20]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M06_L01
       cmp       qword ptr [rbp-8],0
       je        short M06_L01
       mov       rcx,[rbp-8]
       call      qword ptr [7FFC8DEB66A0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.EnsureConfigured()
       jmp       short M06_L01
M06_L00:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M06_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFC8DEB5A28]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       [rbp-8],rax
M06_L01:
       cmp       qword ptr [rbp-8],0
       jne       short M06_L02
       lea       rcx,[rbp+28]
       call      qword ptr [7FFC8DD74720]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].GetValueOrDefault()
       test      eax,eax
       je        short M06_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC8DEB5488]; System.Text.Json.JsonSerializerOptions.get_TypeInfoResolver()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC8DEBCF60]
M06_L02:
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 219
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SerializationBenchmarks.FerrisValueMapping()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rcx,15882404188
       mov       rsi,[rcx]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+30]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFC8DA066D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+40],0
       je        near ptr M00_L04
       cmp       dword ptr [rsp+40],1
       je        near ptr M00_L05
       mov       edi,[rsp+40]
       test      edi,edi
       jl        near ptr M00_L06
       mov       rbp,[rsp+30]
       test      rbp,rbp
       je        near ptr M00_L07
       mov       r14d,[rbp+8]
       cmp       r14d,edi
       je        short M00_L01
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       lea       rcx,[r15+10]
       lea       rdx,[rbp+10]
       cmp       edi,r14d
       cmovg     edi,r14d
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        short M00_L03
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       mov       [rsp+30],r15
M00_L01:
       mov       ecx,[rsp+40]
       mov       [rsp+44],ecx
       mov       rcx,[rsp+30]
M00_L02:
       mov       rdx,rsi
       call      qword ptr [7FFC8DEB4330]; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
       mov       rcx,rax
       mov       esi,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,49879D50
       mov       r9d,831528EF
       call      qword ptr [7FFC8DF2F288]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,esi
       mov       [rbx+8],eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L03:
       call      qword ptr [7FFC8DB65BD8]
       jmp       short M00_L00
M00_L04:
       mov       rdx,15882401EB8
       mov       rcx,[rdx]
       jmp       short M00_L02
M00_L05:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,[rsp+38]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rdi
       jmp       short M00_L02
M00_L06:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFC8DC4ED48]
       int       3
M00_L07:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+30],rax
       jmp       near ptr M00_L01
; Total bytes of code 390
```
```assembly
; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       rbp,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       ebx,r9d
       mov       r14,[rsp+0D0]
       xor       r15d,r15d
       xor       r13d,r13d
       test      rsi,rsi
       je        near ptr M01_L03
       test      bl,1
       je        short M01_L00
       mov       rdx,rsi
       mov       rcx,15882400590
       mov       rcx,[rcx]
       call      qword ptr [7FFC8DEB4498]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
       mov       rsi,rax
       mov       r13d,1
       mov       r12d,2
       jmp       short M01_L01
M01_L00:
       mov       r12d,1
M01_L01:
       cmp       byte ptr [rsp+0D8],0
       je        short M01_L04
       mov       ecx,[rsi+8]
       mov       eax,ecx
       cmp       word ptr [rsi+rax*2+0A],2A
       jne       short M01_L04
       mov       r12,rsi
       lea       r15d,[rcx-1]
       cmp       ecx,r15d
       jb        near ptr M01_L23
       test      r15d,r15d
       je        near ptr M01_L10
       cmp       ecx,r15d
       je        near ptr M01_L09
       mov       ecx,r15d
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       mov       r8d,r15d
       cmp       [rsi],sil
       lea       rcx,[rsi+0C]
       lea       rdx,[r12+0C]
       add       r8,r8
       call      qword ptr [7FFC8DB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L02:
       mov       r15d,1
M01_L03:
       xor       r12d,r12d
M01_L04:
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        near ptr M01_L11
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L11
       mov       rbp,rax
M01_L05:
       mov       [rsp+38],rsi
       cmp       [rbp],bpl
       lea       rdx,[rbp+60]
       mov       [rsp+30],rdx
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L07
       mov       rax,[rsp+38]
M01_L06:
       mov       rbp,r8
       cmp       [rbp],bpl
       cmp       r12d,1
       je        near ptr M01_L12
       cmp       r12d,2
       je        near ptr M01_L14
       jmp       near ptr M01_L16
M01_L07:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimePropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,[rsp+28]
       mov       rcx,[rsp+30]
       mov       rdx,rbp
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       r8,rax
       test      r8,r8
       cmove     r8,rbp
       mov       rax,[rsp+38]
       jmp       short M01_L06
M01_L08:
       mov       rcx,rbp
       mov       r8d,r12d
       xor       edx,edx
       mov       r9d,3
       call      qword ptr [7FFC8DCA67F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
       jmp       near ptr M01_L17
M01_L09:
       mov       rsi,r12
       jmp       near ptr M01_L02
M01_L10:
       mov       rsi,19916E80008
       jmp       near ptr M01_L02
M01_L11:
       mov       rcx,rbp
       call      qword ptr [7FFC8DA06658]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
       jmp       near ptr M01_L05
M01_L12:
       lea       rcx,[rbp+20]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFC8DCA5008]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M01_L13
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FFC8DCA67F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M01_L13:
       mov       r12,rax
       jmp       short M01_L17
M01_L14:
       lea       rcx,[rbp+28]
       mov       r8,rax
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimePropertyInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFC8DCA5008]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L15
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       mov       r8d,2
       mov       r9d,3
       call      qword ptr [7FFC8DCA67F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
M01_L15:
       jmp       short M01_L17
M01_L16:
       cmp       byte ptr [rbp+18],0
       je        near ptr M01_L08
       mov       r12,[rbp+8]
M01_L17:
       xor       ebx,2
       mov       ebp,[r12+8]
       mov       ecx,ebp
       xor       r8d,r8d
       mov       [rsp+50],r8
       mov       [rsp+58],r8
       mov       [rsp+60],r8d
       mov       [rsp+64],ecx
       xor       eax,eax
       test      ebp,ebp
       jle       short M01_L20
M01_L18:
       mov       [rsp+4C],eax
       mov       ecx,eax
       mov       r10,[r12+rcx*8+10]
       mov       [rsp+40],r10
       mov       ecx,[r10+58]
       mov       r8d,ebx
       and       r8d,ecx
       cmp       r8d,ecx
       je        short M01_L21
M01_L19:
       mov       eax,[rsp+4C]
       inc       eax
       cmp       ebp,eax
       jg        short M01_L18
M01_L20:
       mov       rdx,[rsp+50]
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rsp+60]
       mov       [rdi+10],eax
       mov       eax,[rsp+64]
       mov       [rdi+14],eax
       mov       rax,rdi
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L21:
       test      r15d,r15d
       jne       short M01_L24
       test      r14,r14
       jne       short M01_L25
M01_L22:
       lea       rcx,[rsp+50]
       mov       r8,r10
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFC8DCA4F60]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       short M01_L19
M01_L23:
       mov       rcx,r12
       mov       r8d,r15d
       xor       edx,edx
       call      qword ptr [7FFC8DAB7258]
       int       3
M01_L24:
       mov       rcx,r10
       mov       rdx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFC8DA06538]
       test      eax,eax
       je        near ptr M01_L19
       mov       r10,[rsp+40]
       test      r14,r14
       je        short M01_L22
M01_L25:
       mov       rcx,r10
       call      qword ptr [7FFC8DD5D0B8]; Precode of System.Reflection.RuntimePropertyInfo.GetIndexParameters()
       mov       eax,[rax+8]
       cmp       eax,[r14+8]
       jne       near ptr M01_L19
       mov       r10,[rsp+40]
       jmp       short M01_L22
; Total bytes of code 836
```
```assembly
; Ferris.Json.JsonTransformer.MapProperties(System.Reflection.PropertyInfo[], System.Object)
M02_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,258
       vzeroupper
       xor       eax,eax
       mov       [rsp+0D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+0F0],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M02_L01:
       vmovdqa   xmmword ptr [rsp+rax+250],xmm4
       vmovdqa   xmmword ptr [rsp+rax+260],xmm4
       vmovdqa   xmmword ptr [rsp+rax+270],xmm4
       add       rax,30
       jne       short M02_L01
       mov       [rsp+250],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M02_L96
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M02_L02:
       xor       ebp,ebp
       cmp       dword ptr [rsi+8],0
       jle       near ptr M02_L32
M02_L03:
       mov       ecx,ebp
       mov       r14,[rsi+rcx*8+10]
       mov       r15,[r14]
       mov       r13,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       r15,r13
       jne       near ptr M02_L97
       mov       rcx,r14
       cmp       qword ptr [rcx+18],0
       jne       short M02_L05
       xor       ecx,ecx
M02_L04:
       test      rcx,rcx
       je        near ptr M02_L88
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFC8DC93210]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r12,rax
       jmp       short M02_L06
M02_L05:
       mov       rcx,[r14+18]
       jmp       short M02_L04
M02_L06:
       cmp       r15,r13
       jne       near ptr M02_L99
       mov       rcx,r14
       cmp       qword ptr [rcx+38],0
       je        near ptr M02_L17
M02_L07:
       mov       rdx,[r14+38]
       mov       rax,[rdx+18]
M02_L08:
       mov       r10,rax
       mov       [rsp+0D0],r10
       mov       rdx,offset MT_System.RuntimeType
       cmp       [r10],rdx
       jne       near ptr M02_L101
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+1E0]
       mov       rcx,r10
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFC8DA066D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+1F0],0
       je        near ptr M02_L16
       cmp       dword ptr [rsp+1F0],1
       je        near ptr M02_L98
       mov       eax,[rsp+1F0]
       mov       [rsp+1DC],eax
       test      eax,eax
       jl        near ptr M02_L89
       mov       r8,[rsp+1E0]
       mov       [rsp+0A8],r8
       test      r8,r8
       je        near ptr M02_L100
       cmp       [r8+8],eax
       je        short M02_L11
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+0A0],rax
       lea       rcx,[rax+10]
       mov       rdx,[rsp+0A8]
       lea       r10,[rdx+10]
       mov       edx,[rdx+8]
       mov       r9d,[rsp+1DC]
       cmp       r9d,edx
       jg        short M02_L15
       mov       edx,r9d
M02_L09:
       mov       r8d,edx
       shl       r8,3
       cmp       r8,4000
       ja        short M02_L13
       mov       rdx,r10
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M02_L10:
       mov       rcx,[rsp+0A0]
       mov       [rsp+1E0],rcx
M02_L11:
       mov       ecx,[rsp+1F0]
       mov       [rsp+1F4],ecx
       mov       rax,[rsp+1E0]
M02_L12:
       mov       rdx,rax
       jmp       near ptr M02_L18
M02_L13:
       mov       rdx,r10
       call      qword ptr [7FFC8DB65BD8]
       jmp       short M02_L10
M02_L14:
       xor       ecx,ecx
       mov       [rsp+1A8],rcx
       jmp       near ptr M02_L64
M02_L15:
       jmp       short M02_L09
M02_L16:
       mov       rdx,15882401EB8
       mov       rax,[rdx]
       jmp       short M02_L12
M02_L17:
       mov       rcx,[r14+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rsp+0B8],rax
       cmp       [rax],al
       mov       rcx,rax
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rdx,[rsp+0B8]
       mov       [rsp+220],rdx
       mov       [rsp+228],rax
       lea       rdx,[rsp+200]
       mov       [rsp+20],rdx
       mov       edx,[r14+50]
       lea       rcx,[rsp+220]
       lea       r8,[rsp+218]
       lea       r9,[rsp+210]
       call      qword ptr [7FFC8DD05740]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       rax,[rsp+208]
       mov       [rsp+1F8],rax
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0C0],rax
       mov       r9,[r14+30]
       mov       rcx,rax
       mov       rdx,[rsp+1F8]
       mov       r8d,[rsp+200]
       call      qword ptr [7FFC8DCA7AC8]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       lea       rcx,[r14+38]
       mov       rdx,[rsp+0C0]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L07
M02_L18:
       mov       [rsp+0C8],rdx
       test      r12,r12
       je        near ptr M02_L86
       mov       rcx,19916E80020
       mov       rax,[rsp+0D0]
       cmp       rax,rcx
       je        near ptr M02_L39
       mov       rcx,19916E887B8
       cmp       rax,rcx
       je        near ptr M02_L39
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M02_L136
       mov       rcx,rax
       call      qword ptr [7FFC8DA07330]; System.RuntimeType.GetBaseType()
M02_L19:
       mov       rcx,19916E821B8
       cmp       rax,rcx
       je        near ptr M02_L105
M02_L20:
       mov       rcx,19916E88820
       mov       r8,[rsp+0D0]
       cmp       r8,rcx
       je        near ptr M02_L21
       mov       rcx,19916E88660
       cmp       r8,rcx
       je        near ptr M02_L21
       mov       rcx,19916E84FC0
       cmp       r8,rcx
       je        near ptr M02_L21
       mov       rcx,19916E88848
       cmp       r8,rcx
       je        near ptr M02_L21
       mov       rcx,19916E85F58
       cmp       r8,rcx
       je        near ptr M02_L21
       mov       rcx,19916E88870
       cmp       r8,rcx
       je        near ptr M02_L21
       mov       rcx,19916E88898
       cmp       r8,rcx
       je        near ptr M02_L21
       mov       rcx,19916E888C0
       cmp       r8,rcx
       je        short M02_L21
       mov       rcx,19916E888E8
       cmp       r8,rcx
       je        short M02_L21
       mov       rcx,19916E85718
       cmp       r8,rcx
       je        short M02_L21
       mov       rcx,19916E88910
       cmp       r8,rcx
       je        short M02_L21
       mov       rcx,19916E88938
       cmp       r8,rcx
       je        short M02_L21
       mov       rcx,19916E88960
       cmp       r8,rcx
       je        short M02_L21
       mov       rcx,19916E84B88
       cmp       r8,rcx
       je        short M02_L21
       mov       rcx,19916E88988
       cmp       r8,rcx
       jne       near ptr M02_L68
M02_L21:
       xor       ecx,ecx
       mov       [rsp+230],rcx
       mov       rcx,15882401E70
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFC8DC89EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+238],rax
       test      rax,rax
       je        near ptr M02_L138
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M02_L22:
       mov       [rsp+248],rdx
       mov       [rsp+250],eax
       xor       ecx,ecx
       mov       [rsp+240],ecx
       mov       byte ptr [rsp+244],0
       mov       ecx,[rsp+240]
       cmp       ecx,[rsp+250]
       ja        near ptr M02_L95
       mov       rax,[rsp+248]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+250]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L139
       mov       rcx,19916E88784
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+240]
       inc       ecx
       mov       [rsp+240],ecx
M02_L23:
       cmp       r15,r13
       jne       near ptr M02_L143
       mov       r15,[r14+8]
       test      r15,r15
       je        near ptr M02_L33
M02_L24:
       cmp       byte ptr [rsp+244],0
       jne       near ptr M02_L144
M02_L25:
       test      r15,r15
       je        near ptr M02_L144
       mov       r8d,[rsp+240]
       cmp       r8d,[rsp+250]
       ja        near ptr M02_L95
       mov       rcx,[rsp+248]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+250]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L144
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC8DB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+240]
       add       ecx,[r15+8]
       mov       [rsp+240],ecx
M02_L26:
       mov       ecx,[rsp+240]
       cmp       ecx,[rsp+250]
       ja        near ptr M02_L95
       mov       r8,[rsp+248]
       mov       edx,ecx
       lea       r8,[r8+rdx*2]
       mov       edx,[rsp+250]
       sub       edx,ecx
       cmp       edx,2
       jb        near ptr M02_L145
       mov       rcx,19916E8880C
       mov       edx,[rcx]
       mov       [r8],edx
       mov       ecx,[rsp+240]
       add       ecx,2
       mov       [rsp+240],ecx
M02_L27:
       lea       rcx,[rsp+230]
       mov       r8,r12
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFC8DD36EF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rsp+240]
       cmp       ecx,[rsp+250]
       ja        near ptr M02_L95
       mov       rax,[rsp+248]
       mov       [rsp+0E8],rax
       mov       [rsp+0F0],ecx
       lea       rcx,[rsp+0E8]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       r15,[rsp+238]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+230],ymm0
       vmovdqu   xmmword ptr [rsp+248],xmm0
       test      r15,r15
       je        near ptr M02_L30
       mov       rcx,15882401E70
       mov       r14,[rcx]
       mov       ecx,[r15+8]
       dec       ecx
       or        ecx,0F
       xor       r13d,r13d
       lzcnt     r13d,ecx
       xor       r13d,1F
       add       r13d,0FFFFFFFD
       mov       rcx,7FFC8D9F5120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L102
M02_L28:
       xor       eax,eax
       mov       dword ptr [rsp+140],1
       cmp       [rcx+8],r13d
       jbe       short M02_L29
       mov       dword ptr [rsp+144],1
       mov       edx,10
       shlx      edx,edx,r13d
       cmp       [r15+8],edx
       jne       near ptr M02_L92
       cmp       r13d,[rcx+8]
       jae       near ptr M02_L185
       mov       edx,r13d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rsp+50],r10
       mov       r9,[r10]
       mov       [rsp+48],r9
       mov       rcx,r10
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+50]
       mov       [rdx+8],ecx
       mov       rax,[rsp+48]
       test      rax,rax
       mov       [rsp+48],rax
       mov       eax,[rsp+144]
       jne       near ptr M02_L103
M02_L29:
       mov       rcx,158824005D0
       mov       r10,[rcx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M02_L158
M02_L30:
       mov       rdx,r12
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L53
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       cmp       eax,[rcx+8]
       jae       near ptr M02_L185
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M02_L31:
       inc       ebp
       cmp       [rsi+8],ebp
       jg        near ptr M02_L03
M02_L32:
       mov       rdx,rdi
       mov       rcx,19916E80C60
       call      qword ptr [7FFC8DAB6DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rdx,rax
       mov       rcx,19916E889D8
       mov       r8,19916E889F0
       call      qword ptr [7FFC8DAB6B20]; System.String.Concat(System.String, System.String, System.String)
       nop
       add       rsp,258
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L33:
       mov       r15,[r14+48]
       test      r15,r15
       je        near ptr M02_L140
       mov       rcx,r15
       call      qword ptr [7FFC8DB65050]; System.SpanHelpers.IndexOfNullByte(Byte*)
M02_L34:
       mov       r8,158824009F0
       mov       r13,[r8]
       test      eax,eax
       jl        near ptr M02_L95
       test      eax,eax
       je        near ptr M02_L38
       mov       r10,r15
M02_L35:
       mov       [rsp+170],r10
       mov       r15,r10
       mov       [rsp+16C],eax
       test      r15,r15
       je        near ptr M02_L91
       lea       r8,[rsp+150]
       lea       r9,[rsp+148]
       mov       rcx,r15
       mov       edx,[rsp+16C]
       call      qword ptr [7FFC8DC47F48]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       sub       rax,r15
       mov       r9d,eax
       mov       eax,r9d
       add       eax,[rsp+150]
       mov       r8d,[rsp+16C]
       cmp       r9d,r8d
       jne       near ptr M02_L141
M02_L36:
       mov       [rsp+168],eax
       test      eax,eax
       je        near ptr M02_L142
       mov       ecx,eax
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+68],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       [rsp+160],rcx
       mov       rcx,r13
       mov       rdx,r15
       mov       r13d,[rsp+16C]
       mov       r8d,r13d
       mov       r9,[rsp+160]
       mov       r15d,[rsp+168]
       mov       [rsp+20],r15d
       call      qword ptr [7FFC8DC3A4D0]; System.Text.UTF8Encoding.GetChars(Byte*, Int32, Char*, Int32)
       xor       ecx,ecx
       mov       [rsp+160],rcx
       mov       r15,[rsp+68]
M02_L37:
       xor       ecx,ecx
       mov       [rsp+160],rcx
       mov       [rsp+170],rcx
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L24
M02_L38:
       mov       r10d,1
       jmp       near ptr M02_L35
M02_L39:
       xor       ecx,ecx
       mov       [rsp+230],rcx
       mov       rcx,15882401E70
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFC8DC89EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+238],rax
       test      rax,rax
       je        near ptr M02_L106
       lea       rdx,[rax+10]
       mov       eax,[rax+8]
M02_L40:
       mov       [rsp+248],rdx
       mov       [rsp+250],eax
       xor       ecx,ecx
       mov       [rsp+240],ecx
       mov       byte ptr [rsp+244],0
       mov       ecx,[rsp+240]
       cmp       ecx,[rsp+250]
       ja        near ptr M02_L95
       mov       rax,[rsp+248]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+250]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L107
       mov       rcx,19916E88784
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+240]
       inc       ecx
       mov       [rsp+240],ecx
M02_L41:
       cmp       r15,r13
       jne       near ptr M02_L75
       mov       r15,[r14+8]
       test      r15,r15
       je        near ptr M02_L60
M02_L42:
       cmp       byte ptr [rsp+244],0
       jne       near ptr M02_L76
M02_L43:
       test      r15,r15
       je        near ptr M02_L76
       mov       r8d,[rsp+240]
       cmp       r8d,[rsp+250]
       ja        near ptr M02_L95
       mov       rcx,[rsp+248]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+250]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M02_L76
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC8DB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+240]
       add       edx,[r15+8]
       mov       [rsp+240],edx
M02_L44:
       mov       edx,[rsp+240]
       cmp       edx,[rsp+250]
       ja        near ptr M02_L95
       mov       rcx,[rsp+248]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+250]
       sub       eax,edx
       cmp       eax,3
       jb        near ptr M02_L77
       mov       rdx,19916E887EC
       mov       eax,[rdx]
       mov       r8d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r8d
       mov       edx,[rsp+240]
       add       edx,3
       mov       [rsp+240],edx
M02_L45:
       mov       [rsp+1C0],r12
       cmp       byte ptr [rsp+244],0
       jne       near ptr M02_L111
       mov       rdx,[rsp+1C0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC8DAB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L81
       mov       rdx,[rsp+1C0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC8DAB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L59
M02_L46:
       mov       rdx,[rsp+1C0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC8DAB43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       edx,[rsp+240]
       cmp       edx,[rsp+250]
       ja        near ptr M02_L95
       mov       rcx,[rsp+248]
       mov       r9d,edx
       lea       rcx,[rcx+r9*2]
       mov       r9d,[rsp+250]
       sub       r9d,edx
       xor       r8d,r8d
       mov       rdx,offset MT_System.UInt64
       cmp       [rax],rdx
       jne       near ptr M02_L63
       add       rax,8
       mov       r8,[rax]
       mov       rax,r8
       or        rax,1
       lzcnt     rax,rax
       xor       eax,3F
       cdqe
       mov       rdx,7FFCEA3B3070
       movzx     eax,byte ptr [rax+rdx]
       mov       edx,eax
       mov       r11,7FFCEA3B9A28
       cmp       r8,[r11+rdx*8]
       setb      dl
       movzx     edx,dl
       sub       eax,edx
       cmp       eax,r9d
       jg        near ptr M02_L80
       mov       [rsp+1B0],eax
       mov       [rsp+1A8],rcx
       cdqe
       lea       r9,[rcx+rax*2]
       cmp       r8,0A
       jb        near ptr M02_L79
       cmp       r8,64
       jb        near ptr M02_L52
       mov       rax,15882400290
       mov       rcx,[rax]
M02_L47:
       add       r9,0FFFFFFFFFFFFFFFC
       mov       rdx,28F5C28F5C28F5C3
       mov       rax,r8
       shr       rax,2
       mul       rdx
       shr       rdx,2
       imul      r11,rdx,64
       sub       r8,r11
       mov       r11,rcx
       shl       r8d,2
       mov       r8d,[r11+r8+10]
       mov       [r9],r8d
       cmp       rdx,64
       jae       short M02_L51
M02_L48:
       cmp       rdx,0A
       jb        short M02_L50
       add       r9,0FFFFFFFFFFFFFFFC
       mov       rcx,15882400290
       mov       rcx,[rcx]
       shl       edx,2
       mov       ecx,[rcx+rdx+10]
       mov       [r9],ecx
M02_L49:
       xor       ecx,ecx
       mov       [rsp+1A8],rcx
       mov       eax,1
       jmp       near ptr M02_L14
M02_L50:
       mov       r8,rdx
       jmp       near ptr M02_L79
M02_L51:
       mov       r8,rdx
       jmp       short M02_L47
M02_L52:
       mov       rdx,r8
       jmp       short M02_L48
M02_L53:
       mov       rcx,rdi
       call      qword ptr [7FFC8DB6E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L31
M02_L54:
       xor       ecx,ecx
       mov       [rsp+1B8],rcx
       mov       ecx,[rsp+240]
       cmp       ecx,[rsp+250]
       ja        near ptr M02_L95
       mov       rax,[rsp+248]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+250]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M02_L118
       mov       rcx,19916E88784
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+240]
       inc       ecx
       mov       [rsp+240],ecx
M02_L55:
       mov       ecx,[rsp+240]
       cmp       ecx,[rsp+250]
       ja        near ptr M02_L95
       mov       rax,[rsp+248]
       mov       [rsp+0E8],rax
       mov       [rsp+0F0],ecx
       lea       rcx,[rsp+0E8]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       r13,[rsp+238]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+230],ymm0
       vmovdqu   xmmword ptr [rsp+248],xmm0
       test      r13,r13
       je        near ptr M02_L58
       mov       rcx,15882401E70
       mov       r15,[rcx]
       mov       ecx,[r13+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFC8D9F5120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M02_L108
M02_L56:
       xor       eax,eax
       mov       dword ptr [rsp+1A0],1
       cmp       [rcx+8],r14d
       jbe       short M02_L57
       mov       dword ptr [rsp+1A4],1
       mov       edx,10
       shlx      edx,edx,r14d
       cmp       [r13+8],edx
       jne       near ptr M02_L90
       mov       edx,r14d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rsp+88],r10
       mov       r9,[r10]
       mov       [rsp+80],r9
       mov       rcx,r10
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+88]
       mov       [rdx+8],ecx
       mov       rax,[rsp+80]
       test      rax,rax
       mov       [rsp+80],rax
       mov       eax,[rsp+1A4]
       jne       near ptr M02_L109
M02_L57:
       mov       rcx,158824005D0
       mov       r10,[rcx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M02_L131
M02_L58:
       mov       rdx,r12
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L62
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L31
M02_L59:
       mov       rdx,[rsp+1C0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC8DAB43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rsp+230]
       mov       r11,7FFC8D970570
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M02_L84
M02_L60:
       mov       r15,[r14+48]
       test      r15,r15
       je        near ptr M02_L112
       mov       rcx,r15
       call      qword ptr [7FFC8DB65050]; System.SpanHelpers.IndexOfNullByte(Byte*)
M02_L61:
       mov       [rsp+1C8],r15
       mov       [rsp+1D0],eax
       lea       rcx,[rsp+1C8]
       call      qword ptr [7FFC8DCA6B98]; System.MdUtf8String.ToString()
       mov       r15,rax
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L42
M02_L62:
       mov       rcx,rdi
       call      qword ptr [7FFC8DB6E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L31
M02_L63:
       mov       rdx,rax
       mov       [rsp+0D8],rcx
       mov       [rsp+0E0],r9d
       mov       [rsp+0E8],r8
       xor       ecx,ecx
       mov       [rsp+0F0],ecx
       mov       rcx,[rsp+230]
       mov       [rsp+20],rcx
       mov       rcx,rdx
       lea       rdx,[rsp+0D8]
       lea       r9,[rsp+0E8]
       lea       r8,[rsp+1B0]
       mov       r11,7FFC8D970578
       call      qword ptr [r11]
M02_L64:
       test      eax,eax
       je        near ptr M02_L78
       mov       r8d,[rsp+240]
       add       r8d,[rsp+1B0]
       mov       [rsp+240],r8d
       jmp       near ptr M02_L54
M02_L65:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rcx,rax
M02_L66:
       cmp       [rcx],cl
       test      r14,r14
       je        near ptr M02_L93
       mov       rdx,r14
       call      qword ptr [7FFC8DEB4498]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
       mov       r14,rax
       test      r13,r13
       je        near ptr M02_L167
       cmp       dword ptr [r13+8],0
       je        near ptr M02_L167
       test      r14,r14
       je        near ptr M02_L168
       cmp       dword ptr [r14+8],0
       je        near ptr M02_L168
       mov       ecx,[r13+8]
       mov       eax,[r14+8]
       lea       rcx,[rcx+rax+3]
       cmp       rcx,7FFFFFFF
       jg        near ptr M02_L94
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       [r12],r12b
       lea       r8,[r12+0C]
       mov       rcx,19916E88784
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r12+0E]
       lea       rdx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8,r8
       call      qword ptr [7FFC8DB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[r13+8]
       inc       r8d
       movsxd    r8,r8d
       lea       r8,[r12+r8*2+0C]
       mov       rcx,19916E8880C
       mov       edx,[rcx]
       mov       [r8],edx
       mov       r8d,[r13+8]
       add       r8d,3
       movsxd    r8,r8d
       lea       rcx,[r12+r8*2+0C]
       lea       rdx,[r14+0C]
       mov       r8d,[r14+8]
       add       r8,r8
       call      qword ptr [7FFC8DB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,r12
M02_L67:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L85
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       cmp       eax,[rcx+8]
       jae       near ptr M02_L185
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L31
M02_L68:
       mov       rdx,19916E83C30
       cmp       r8,rdx
       jne       near ptr M02_L169
       cmp       r15,r13
       jne       near ptr M02_L163
       mov       r13,[r14+8]
       test      r13,r13
       je        near ptr M02_L74
M02_L69:
       mov       rcx,offset MT_System.Boolean
       cmp       [r12],rcx
       jne       near ptr M02_L164
       add       r12,8
       cmp       byte ptr [r12],0
       je        near ptr M02_L113
       mov       r14,19916E88A28
M02_L70:
       cmp       [r14],r14b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M02_L114
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M02_L114
       mov       rax,[rcx]
       add       rax,10
M02_L71:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M02_L72
       mov       rcx,15882400438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M02_L72
       mov       rcx,15882400418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M02_L165
M02_L72:
       mov       r12,rcx
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r12],rcx
       jne       near ptr M02_L65
       cmp       qword ptr [r12+10],0
       je        near ptr M02_L166
M02_L73:
       mov       rcx,[r12+10]
       jmp       near ptr M02_L66
M02_L74:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+108],xmm0
       mov       rdx,[r14+48]
       lea       rcx,[rsp+108]
       call      qword ptr [7FFC8DCA6B20]
       vmovups   xmm0,[rsp+108]
       vmovups   [rsp+0F8],xmm0
       lea       rcx,[rsp+0F8]
       call      qword ptr [7FFC8DCA6B98]; System.MdUtf8String.ToString()
       mov       r13,rax
       lea       rcx,[r14+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L69
M02_L75:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       cmp       byte ptr [rsp+244],0
       je        near ptr M02_L43
M02_L76:
       lea       rcx,[rsp+230]
       mov       rdx,r15
       call      qword ptr [7FFC8DBD5848]
       jmp       near ptr M02_L44
M02_L77:
       lea       rcx,[rsp+230]
       mov       rdx,19916E887E0
       call      qword ptr [7FFC8DBD58F0]
       jmp       near ptr M02_L45
M02_L78:
       lea       rcx,[rsp+230]
       call      qword ptr [7FFC8DBD5938]
       jmp       near ptr M02_L46
M02_L79:
       lea       ecx,[r8+30]
       mov       [r9-2],cx
       jmp       near ptr M02_L49
M02_L80:
       xor       ecx,ecx
       mov       [rsp+1B0],ecx
       xor       eax,eax
       jmp       near ptr M02_L14
M02_L81:
       xor       r8d,r8d
       mov       [rsp+1B8],r8
       lea       r8,[rsp+1C0]
       cmp       qword ptr [rsp+1B8],0
       jne       short M02_L82
       mov       r8,[r8]
       mov       [rsp+1B8],r8
       lea       r8,[rsp+1B8]
       cmp       qword ptr [rsp+1B8],0
       je        near ptr M02_L115
M02_L82:
       mov       rcx,[r8]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M02_L116
M02_L83:
       mov       rdx,rcx
M02_L84:
       test      rdx,rdx
       je        near ptr M02_L54
       mov       r8d,[rsp+240]
       cmp       r8d,[rsp+250]
       ja        near ptr M02_L95
       mov       rcx,[rsp+248]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+250]
       sub       eax,r8d
       mov       r13d,[rdx+8]
       cmp       r13d,eax
       ja        near ptr M02_L117
       add       rdx,0C
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFC8DB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rsp+240]
       mov       [rsp+240],r13d
       jmp       near ptr M02_L54
M02_L85:
       mov       rcx,rdi
       call      qword ptr [7FFC8DB6E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L31
M02_L86:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,19916E88778
       mov       r8,19916E88790
       call      qword ptr [7FFC8DAB6B20]; System.String.Concat(System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M02_L87
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L31
M02_L87:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC8DB6E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L31
M02_L88:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC8DEFCBD0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC8DABF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L89:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFC8DC4ED48]
       int       3
M02_L90:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC8DEFEE50]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFC8D964000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC8DABF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L91:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFC8DC4ED18]
       int       3
M02_L92:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC8DEFEE50]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFC8D964000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC8DABF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L93:
       mov       ecx,16EB
       mov       rdx,7FFC8D964000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC8DC766E8]
       int       3
M02_L94:
       call      qword ptr [7FFC8DC4EF40]
       int       3
M02_L95:
       call      qword ptr [7FFC8DC4E9D0]
       int       3
M02_L96:
       mov       rcx,15882401E88
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L02
M02_L97:
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[r15+58]
       call      qword ptr [rax+38]
       mov       r12,rax
       jmp       near ptr M02_L06
M02_L98:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+0B0],rax
       mov       rcx,rax
       mov       r8,[rsp+1E8]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,[rsp+0B0]
       jmp       near ptr M02_L12
M02_L99:
       mov       rcx,r14
       mov       rax,[r15+50]
       call      qword ptr [rax+10]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M02_L08
M02_L100:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+1E0],rax
       jmp       near ptr M02_L11
M02_L101:
       mov       rcx,r10
       mov       edx,1C
       mov       rax,[r10]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rdx,rcx
       jmp       near ptr M02_L18
M02_L102:
       mov       rcx,r14
       call      qword ptr [7FFC8DC7D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L28
M02_L103:
       mov       rcx,[r14+10]
       cmp       r13d,[rcx+8]
       jae       near ptr M02_L185
       mov       edx,r13d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rsp+144],eax
       jne       short M02_L104
       mov       rcx,r14
       mov       edx,r13d
       call      qword ptr [7FFC8DC7D7E8]
       mov       r10,rax
M02_L104:
       mov       r10,[r10+8]
       mov       [rsp+40],r10
       mov       rcx,7FFC8D9F5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFC8D9F5C38],0
       je        near ptr M02_L146
       call      qword ptr [7FFC8DABDC98]
       mov       edx,eax
       mov       [rsp+128],edx
       jmp       near ptr M02_L149
M02_L105:
       mov       rcx,[rsp+0C8]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L20
       mov       rcx,[rsp+0C8]
       mov       rdx,r12
       call      qword ptr [7FFC8DEB4330]
       mov       r13,rax
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       r9,r13
       mov       rcx,19916E88778
       mov       r8,19916E88800
       call      qword ptr [7FFC8DAB6B38]; System.String.Concat(System.String, System.String, System.String, System.String)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M02_L137
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L31
M02_L106:
       xor       edx,edx
       xor       eax,eax
       jmp       near ptr M02_L40
M02_L107:
       lea       rcx,[rsp+230]
       mov       rdx,19916E88778
       call      qword ptr [7FFC8DBD58F0]
       jmp       near ptr M02_L41
M02_L108:
       mov       rcx,r15
       call      qword ptr [7FFC8DC7D860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M02_L56
M02_L109:
       mov       rcx,[r15+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M02_L185
       mov       edx,r14d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rsp+1A4],eax
       jne       short M02_L110
       mov       rcx,r15
       mov       edx,r14d
       call      qword ptr [7FFC8DC7D7E8]
       mov       r10,rax
M02_L110:
       mov       r10,[r10+8]
       mov       [rsp+78],r10
       mov       rcx,7FFC8D9F5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFC8D9F5C38],0
       je        near ptr M02_L119
       call      qword ptr [7FFC8DABDC98]
       mov       edx,eax
       mov       [rsp+188],edx
       jmp       near ptr M02_L122
M02_L111:
       lea       rcx,[rsp+230]
       mov       r8,[rsp+1C0]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFC8E0A6490]
       jmp       near ptr M02_L54
M02_L112:
       xor       eax,eax
       jmp       near ptr M02_L61
M02_L113:
       mov       r14,19916E88A08
       jmp       near ptr M02_L70
M02_L114:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M02_L71
M02_L115:
       xor       edx,edx
       jmp       near ptr M02_L84
M02_L116:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L83
M02_L117:
       lea       rcx,[rsp+230]
       call      qword ptr [7FFC8DBD58F0]
       jmp       near ptr M02_L54
M02_L118:
       lea       rcx,[rsp+230]
       mov       rdx,19916E88778
       call      qword ptr [7FFC8DBD58F0]
       jmp       near ptr M02_L55
M02_L119:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rsp+184],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rsp+184]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L120
       call      qword ptr [7FFC8E0A62E0]
       mov       edx,eax
       jmp       short M02_L121
M02_L120:
       mov       edx,ecx
       sar       edx,10
M02_L121:
       mov       [rsp+188],edx
M02_L122:
       mov       rcx,7FFC8D9F5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rsp+188]
       xor       edx,edx
       div       dword ptr [7FFC8D9F5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L129
M02_L123:
       cmp       eax,[r8+8]
       jae       near ptr M02_L185
       mov       [rsp+190],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+70],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+180],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rsp+17C],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L125
       test      r10d,r10d
       jne       short M02_L126
       xor       edx,edx
       mov       [rax+14],edx
M02_L124:
       movsxd    rdx,r10d
       mov       r8,[rsp+80]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+17C]
       inc       ecx
       mov       rax,[rsp+70]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+180],1
M02_L125:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rsp+180]
       test      ecx,ecx
       je        short M02_L127
       mov       r8d,1
       jmp       short M02_L130
M02_L126:
       jmp       short M02_L124
M02_L127:
       mov       eax,[rsp+190]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rsp+78]
       cmp       [rcx+8],r8d
       jne       short M02_L128
       xor       r8d,r8d
M02_L128:
       mov       edx,[rsp+18C]
       inc       edx
       mov       eax,r8d
M02_L129:
       mov       r8,[rsp+78]
       mov       [rsp+18C],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L123
       xor       r8d,r8d
M02_L130:
       mov       eax,r8d
       mov       [rsp+1A0],eax
       mov       eax,[rsp+1A4]
       jmp       near ptr M02_L57
M02_L131:
       mov       edx,eax
       mov       r8,r10
       mov       eax,[rsp+1A0]
       cmp       dword ptr [r13+8],0
       mov       [rsp+1A4],edx
       mov       [rsp+98],r8
       mov       [rsp+1A0],eax
       je        near ptr M02_L58
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+19C],eax
       mov       edx,[r13+8]
       mov       [rsp+198],edx
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+98]
       mov       r8d,[rsp+19C]
       mov       r9d,[rsp+198]
       mov       edx,3
       call      qword ptr [7FFC8DB67678]
       mov       eax,[rsp+1A4]
       test      [rsp+1A0],eax
       mov       [rsp+1A4],eax
       jne       near ptr M02_L58
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[r13+8]
       mov       rdx,[rsp+98]
       mov       [rsp+90],rdx
       mov       [rsp+194],eax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[rsp+1A4]
       test      r15d,r15d
       jne       short M02_L132
       mov       r14,[rsp+90]
       mov       edx,[rsp+194]
       mov       ecx,0FFFFFFFF
       jmp       short M02_L133
M02_L132:
       mov       rdx,[rsp+90]
       mov       ecx,[rsp+194]
       mov       r8d,ecx
       mov       ecx,r14d
       mov       r14,rdx
       mov       edx,r8d
M02_L133:
       mov       r8d,r13d
       mov       r9d,eax
       test      r15d,r15d
       jne       short M02_L134
       mov       eax,1
       jmp       short M02_L135
M02_L134:
       xor       eax,eax
M02_L135:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFC8DC7E2B0]
       jmp       near ptr M02_L58
M02_L136:
       mov       rcx,rax
       mov       rdx,[rax]
       mov       rdx,[rdx+98]
       call      qword ptr [rdx+20]
       jmp       near ptr M02_L19
M02_L137:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC8DB6E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L31
M02_L138:
       xor       edx,edx
       xor       eax,eax
       jmp       near ptr M02_L22
M02_L139:
       lea       rcx,[rsp+230]
       mov       rdx,19916E88778
       call      qword ptr [7FFC8DBD58F0]
       jmp       near ptr M02_L23
M02_L140:
       xor       eax,eax
       jmp       near ptr M02_L34
M02_L141:
       mov       [rsp+15C],eax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8d,[rsp+16C]
       call      qword ptr [7FFC8DABC990]
       add       eax,[rsp+15C]
       mov       ecx,eax
       test      ecx,ecx
       mov       eax,ecx
       jge       near ptr M02_L36
       call      qword ptr [7FFC8DABC7E0]
       int       3
M02_L142:
       mov       r15,19916E80008
       jmp       near ptr M02_L37
M02_L143:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r15,rax
       cmp       byte ptr [rsp+244],0
       je        near ptr M02_L25
M02_L144:
       lea       rcx,[rsp+230]
       mov       rdx,r15
       call      qword ptr [7FFC8DBD5848]
       jmp       near ptr M02_L26
M02_L145:
       lea       rcx,[rsp+230]
       mov       rdx,19916E88800
       call      qword ptr [7FFC8DBD58F0]
       jmp       near ptr M02_L27
M02_L146:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rsp+124],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rsp+124]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M02_L147
       call      qword ptr [7FFC8E0A62E0]
       mov       edx,eax
       jmp       short M02_L148
M02_L147:
       mov       edx,ecx
       sar       edx,10
M02_L148:
       mov       [rsp+128],edx
M02_L149:
       mov       rcx,7FFC8D9F5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rsp+128]
       xor       edx,edx
       div       dword ptr [7FFC8D9F5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M02_L156
M02_L150:
       cmp       eax,[r8+8]
       jae       near ptr M02_L185
       mov       [rsp+130],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+38],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+120],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+38]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rsp+11C],r10d
       cmp       [rcx+8],r10d
       jbe       short M02_L152
       test      r10d,r10d
       jne       short M02_L153
       xor       edx,edx
       mov       [rax+14],edx
M02_L151:
       movsxd    rdx,r10d
       mov       r8,[rsp+48]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+11C]
       inc       ecx
       mov       rax,[rsp+38]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+120],1
M02_L152:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rsp+120]
       test      ecx,ecx
       je        short M02_L154
       mov       r8d,1
       jmp       short M02_L157
M02_L153:
       jmp       short M02_L151
M02_L154:
       mov       eax,[rsp+130]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rsp+40]
       cmp       [rcx+8],r8d
       jne       short M02_L155
       xor       r8d,r8d
M02_L155:
       mov       edx,[rsp+12C]
       inc       edx
       mov       eax,r8d
M02_L156:
       mov       r8,[rsp+40]
       mov       [rsp+12C],edx
       cmp       [r8+8],edx
       jg        near ptr M02_L150
       xor       r8d,r8d
M02_L157:
       mov       eax,r8d
       mov       [rsp+140],eax
       mov       eax,[rsp+144]
       jmp       near ptr M02_L29
M02_L158:
       mov       edx,eax
       mov       r8,r10
       mov       eax,[rsp+140]
       cmp       dword ptr [r15+8],0
       mov       [rsp+144],edx
       mov       [rsp+60],r8
       mov       [rsp+140],eax
       je        near ptr M02_L30
       cmp       [r15],r15b
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+13C],eax
       mov       edx,[r15+8]
       mov       [rsp+138],edx
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+60]
       mov       r8d,[rsp+13C]
       mov       r9d,[rsp+138]
       mov       edx,3
       call      qword ptr [7FFC8DB67678]
       mov       eax,[rsp+144]
       test      [rsp+140],eax
       mov       [rsp+144],eax
       jne       near ptr M02_L30
       cmp       [r15],r15b
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[r15+8]
       mov       rdx,[rsp+60]
       mov       [rsp+58],rdx
       mov       [rsp+134],eax
       mov       rcx,r14
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,[rsp+144]
       test      r14d,r14d
       jne       short M02_L159
       mov       r13,[rsp+58]
       mov       edx,[rsp+134]
       mov       ecx,0FFFFFFFF
       jmp       short M02_L160
M02_L159:
       mov       rdx,[rsp+58]
       mov       ecx,[rsp+134]
       mov       r8d,ecx
       mov       ecx,r13d
       mov       r13,rdx
       mov       edx,r8d
M02_L160:
       mov       r8d,r15d
       mov       r9d,eax
       test      r14d,r14d
       jne       short M02_L161
       mov       eax,1
       jmp       short M02_L162
M02_L161:
       xor       eax,eax
M02_L162:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r13
       call      qword ptr [7FFC8DC7E2B0]
       jmp       near ptr M02_L30
M02_L163:
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       r13,rax
M02_L164:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M02_L70
M02_L165:
       call      qword ptr [7FFC8DBF4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M02_L72
M02_L166:
       mov       rcx,offset MT_System.Globalization.TextInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,[r12+30]
       mov       rcx,r15
       call      qword ptr [7FFC8DBFC018]; System.Globalization.TextInfo..ctor(System.Globalization.CultureData)
       movzx     ecx,byte ptr [r12+60]
       mov       [r15+30],cl
       lea       rcx,[r12+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L73
M02_L167:
       mov       r8,r14
       mov       rcx,19916E88778
       mov       rdx,19916E88800
       call      qword ptr [7FFC8DAB6B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L67
M02_L168:
       mov       rdx,r13
       mov       rcx,19916E88778
       mov       r8,19916E88800
       call      qword ptr [7FFC8DAB6B20]; System.String.Concat(System.String, System.String, System.String)
       mov       rdx,rax
       jmp       near ptr M02_L67
M02_L169:
       mov       rdx,19916E889B0
       cmp       r8,rdx
       jne       near ptr M02_L177
       mov       rdx,r12
       mov       rcx,offset MT_System.DateTime
       call      qword ptr [7FFC8DAB4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       mov       rcx,[rax]
       mov       r8,15882400428
       mov       r8,[r8]
       mov       rdx,19916E86808
       call      qword ptr [7FFC8E1A7630]
       mov       r12,rax
       lea       rcx,[rsp+230]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFC8DBD56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+240]
       cmp       ecx,[rsp+250]
       ja        near ptr M02_L95
       mov       rdx,[rsp+248]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+250]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L170
       mov       rcx,19916E88784
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rsp+240]
       inc       ecx
       mov       [rsp+240],ecx
       jmp       short M02_L171
M02_L170:
       lea       rcx,[rsp+230]
       mov       rdx,19916E88778
       call      qword ptr [7FFC8DBD58F0]
M02_L171:
       mov       rcx,r14
       mov       r15,[r14]
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rsp+230]
       call      qword ptr [7FFC8DBD5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+240]
       cmp       ecx,[rsp+250]
       ja        near ptr M02_L95
       mov       rdx,[rsp+248]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+250]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L172
       mov       rcx,19916E887EC
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rsp+240]
       add       ecx,3
       mov       [rsp+240],ecx
       jmp       short M02_L173
M02_L172:
       lea       rcx,[rsp+230]
       mov       rdx,19916E887E0
       call      qword ptr [7FFC8DBD58F0]
M02_L173:
       lea       rcx,[rsp+230]
       mov       rdx,r12
       call      qword ptr [7FFC8DBD5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+240]
       cmp       ecx,[rsp+250]
       ja        near ptr M02_L95
       mov       rdx,[rsp+248]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+250]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L174
       mov       rcx,19916E88784
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rsp+240]
       inc       ecx
       mov       [rsp+240],ecx
       jmp       short M02_L175
M02_L174:
       lea       rcx,[rsp+230]
       mov       rdx,19916E88778
       call      qword ptr [7FFC8DBD58F0]
M02_L175:
       lea       rcx,[rsp+230]
       call      qword ptr [7FFC8DBD5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L176
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       cmp       edx,[rcx+8]
       jae       near ptr M02_L185
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L31
M02_L176:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC8DB6E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L31
M02_L177:
       lea       rcx,[rsp+230]
       mov       edx,5
       mov       r8d,2
       call      qword ptr [7FFC8DBD56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+240]
       cmp       ecx,[rsp+250]
       ja        near ptr M02_L95
       mov       rdx,[rsp+248]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+250]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L178
       mov       rcx,19916E88784
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rsp+240]
       inc       ecx
       mov       [rsp+240],ecx
       jmp       short M02_L179
M02_L178:
       lea       rcx,[rsp+230]
       mov       rdx,19916E88778
       call      qword ptr [7FFC8DBD58F0]
M02_L179:
       mov       rcx,r14
       mov       r15,[r14]
       mov       rax,[r15+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       lea       rcx,[rsp+230]
       call      qword ptr [7FFC8DBD5830]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+240]
       cmp       ecx,[rsp+250]
       ja        near ptr M02_L95
       mov       rdx,[rsp+248]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+250]
       sub       eax,ecx
       cmp       eax,3
       jb        short M02_L180
       mov       rcx,19916E887EC
       mov       eax,[rcx]
       mov       r8d,[rcx+2]
       mov       [rdx],eax
       mov       [rdx+2],r8d
       mov       ecx,[rsp+240]
       add       ecx,3
       mov       [rsp+240],ecx
       jmp       short M02_L181
M02_L180:
       lea       rcx,[rsp+230]
       mov       rdx,19916E887E0
       call      qword ptr [7FFC8DBD58F0]
M02_L181:
       lea       rcx,[rsp+230]
       mov       r8,r12
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Object, System.Private.CoreLib]](System.Object)
       call      qword ptr [7FFC8DD36EF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rsp+240]
       cmp       ecx,[rsp+250]
       ja        near ptr M02_L95
       mov       rdx,[rsp+248]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+250]
       sub       eax,ecx
       cmp       eax,1
       jb        short M02_L182
       mov       rcx,19916E88784
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       mov       ecx,[rsp+240]
       inc       ecx
       mov       [rsp+240],ecx
       jmp       short M02_L183
M02_L182:
       lea       rcx,[rsp+230]
       mov       rdx,19916E88778
       call      qword ptr [7FFC8DBD58F0]
M02_L183:
       lea       rcx,[rsp+230]
       call      qword ptr [7FFC8DBD5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M02_L184
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       cmp       edx,[rcx+8]
       jae       short M02_L185
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L31
M02_L184:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFC8DB6E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M02_L31
M02_L185:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 8769
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M03_L04
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M03_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M03_L00
       test      dl,4
       jne       short M03_L03
M03_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M03_L02:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M03_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M03_L01
M03_L04:
       cmp       edx,4
       jae       short M03_L03
       mov       eax,80
       test      dl,1
       je        short M03_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M03_L05:
       test      dl,2
       mov       edx,eax
       je        short M03_L02
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       near ptr M03_L02
; Total bytes of code 266
```
**Extern method**
System.Object.GetType()
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SerializationBenchmarks.NewtonsoftValueMapping()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rax,13A93004188
       mov       rsi,[rax]
       call      qword ptr [7FFC8DEB6D18]; Newtonsoft.Json.JsonSerializer.CreateDefault()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC8DEB4738]; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       mov       rcx,rax
       mov       esi,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,8FC61AAF
       mov       r9d,3898872E
       call      qword ptr [7FFC8E035F68]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,esi
       mov       [rbx+8],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 87
```
```assembly
; Newtonsoft.Json.JsonSerializer.CreateDefault()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rcx,13A93004E68
       mov       rax,[rcx]
       test      rax,rax
       jne       short M01_L02
       xor       ebx,ebx
M01_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFC8DEB6CD0]; Newtonsoft.Json.JsonSerializer..ctor()
       test      rbx,rbx
       jne       short M01_L03
M01_L01:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFC8DEB6D48]
       jmp       short M01_L01
; Total bytes of code 94
```
```assembly
; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edx,100
       mov       dword ptr [r14+20],7FFFFFFF
       cmp       edx,400
       jl        near ptr M02_L04
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M02_L00:
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,13A93000428
       mov       r13,[rcx]
       mov       rcx,13A930014E8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,13A80301C08
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],1
       mov       [rbp-38],r15
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       [r14+24],ecx
       mov       dword ptr [r14+2C],3
       mov       byte ptr [r14+38],1
       mov       byte ptr [r14+39],1
       lea       rcx,[r14+58]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       word ptr [r14+8E],22
       mov       byte ptr [r14+91],1
       mov       word ptr [r14+8C],20
       mov       dword ptr [r14+88],2
       mov       ecx,[r14+30]
       mov       rdx,13A93005058
       mov       rax,13A93005060
       cmp       ecx,2
       mov       rdx,[rdx]
       cmove     rdx,[rax]
       lea       rcx,[r14+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],1
       mov       [rbp-40],r14
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       r13d,[rbx+94]
       jmp       short M02_L03
M02_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFC8DEAAD28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC8DB6D458]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       r13d,eax
M02_L03:
       test      r13d,r13d
       jl        short M02_L01
       cmp       r13d,1
       jg        short M02_L01
       mov       [r14+24],r13d
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rax,[rbx]
       mov       rax,[rax+80]
       call      qword ptr [rax+18]
       nop
       mov       rcx,rsp
       call      M02_L05
       nop
       mov       r15,[rbp-38]
       mov       rcx,[r15+20]
       cmp       [rcx],ecx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFC8DCF9968]; System.Text.StringBuilder.ToString()
M02_L04:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M02_L00
M02_L05:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       r14,[rbp-40]
       cmp       dword ptr [r14+20],8
       je        near ptr M02_L15
       cmp       byte ptr [r14+39],0
       je        short M02_L11
       jmp       short M02_L07
M02_L06:
       mov       edx,[r14+48]
       mov       rcx,r14
       call      qword ptr [7FFC8DEBEDF0]
M02_L07:
       mov       rax,[r14+8]
       test      rax,rax
       jne       short M02_L08
       xor       r15d,r15d
       jmp       short M02_L09
M02_L08:
       mov       ecx,[rax+10]
       mov       r15d,ecx
M02_L09:
       cmp       dword ptr [r14+48],0
       je        short M02_L10
       inc       r15d
M02_L10:
       test      r15d,r15d
       jg        short M02_L06
M02_L11:
       mov       rdx,[r14+70]
       test      rdx,rdx
       je        short M02_L13
       mov       rcx,[r14+78]
       test      rcx,rcx
       je        short M02_L12
       mov       r11,7FFC8D970CD0
       call      qword ptr [r11]
M02_L12:
       xor       ecx,ecx
       mov       [r14+70],rcx
M02_L13:
       cmp       byte ptr [r14+38],0
       je        short M02_L15
       mov       rcx,[r14+58]
       test      rcx,rcx
       je        short M02_L15
       mov       rax,offset MT_System.IO.StringWriter
       cmp       [rcx],rax
       jne       short M02_L14
       mov       byte ptr [rcx+28],0
       jmp       short M02_L15
M02_L14:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
M02_L15:
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 774
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M03_L04
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M03_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M03_L00
       test      dl,4
       je        short M03_L02
M03_L01:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
M03_L02:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M03_L03:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M03_L04:
       cmp       edx,4
       jae       short M03_L01
       mov       eax,80
       test      dl,1
       je        short M03_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M03_L05:
       test      dl,2
       mov       edx,eax
       je        short M03_L03
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       short M03_L03
; Total bytes of code 261
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.SerializationBenchmarks.TextJsonValueMapping()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rbx,rcx
       mov       rax,238E2004188
       mov       rax,[rax]
       mov       [rsp+38],rax
       call      qword ptr [7FFC8DEC53E0]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rsi,rax
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L03
M00_L00:
       mov       rdi,[rsi+10]
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rdx,[rdi+0B8]
       mov       r8,23880208750
       cmp       rdx,r8
       jne       short M00_L04
M00_L01:
       mov       rdx,rdi
       mov       r8,rdx
       test      r8,r8
       je        short M00_L02
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       near ptr M00_L05
M00_L02:
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[Ferris.Json.Test.TestObjects.ValueTestObject, Ferris.Json.Test]](Ferris.Json.Test.TestObjects.ValueTestObject ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.ValueTestObject>)
       call      qword ptr [7FFC8DEC6FD0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rcx,rax
       mov       esi,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,0C9528801
       mov       r9d,92A7BF5E
       call      qword ptr [7FFC8DF85140]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,esi
       mov       [rbx+8],eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       mov       rcx,rsi
       call      qword ptr [7FFC8DEC5A10]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L00
M00_L04:
       mov       byte ptr [rsp+30],1
       mov       byte ptr [rsp+31],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       movzx     r9d,word ptr [rsp+30]
       mov       rdx,23880208750
       mov       r8d,1
       call      qword ptr [7FFC8DEC52C0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFC8DAC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 274
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,238E2004F28
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,238E2004F28
       xor       edx,edx
       jmp       qword ptr [7FFC8DEC5AB8]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
; Total bytes of code 37
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DEC5A88]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M02_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M02_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M02_L12
M02_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M02_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,238E2001F80
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFC8E0A8018]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M02_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M02_L02
M02_L01:
       mov       edx,2
M02_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M02_L13
       mov       rdi,23880201C08
M02_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M02_L14
M02_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFC8DEC6D90]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M02_L08
       cmp       [rcx+8],r15d
       jb        short M02_L07
M02_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M02_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M02_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M02_L06:
       cmp       r15d,r12d
       ja        short M02_L07
       mov       r12d,r15d
       jmp       short M02_L10
M02_L07:
       call      qword ptr [7FFC8DC5E9D0]
       int       3
M02_L08:
       test      r15d,r15d
       jne       short M02_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M02_L05
M02_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M02_L06
M02_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFC8DECD908]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M02_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M02_L00
M02_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFC8E09D1E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L00
M02_L13:
       mov       rcx,7FFC8DEBC840
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,238E2004F68
       mov       rdi,[rcx]
       jmp       near ptr M02_L03
M02_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFC8E096748]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M02_L04
M02_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFC8E09CCF0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFC8E0968C8]
       mov       r14,r13
       jmp       near ptr M02_L04
M02_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        short M02_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M02_L18
M02_L17:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L19
M02_L18:
       mov       rax,[rcx]
       add       rax,10
M02_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M02_L20
       test      r10d,r10d
       jne       short M02_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M02_L23
M02_L20:
       cmp       [rcx+8],r10d
       jae       short M02_L22
M02_L21:
       call      qword ptr [7FFC8DC5E9D0]
       int       3
M02_L22:
       add       rcx,10
M02_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M02_L25
       cmp       rdx,300
       ja        short M02_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M02_L25
M02_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFC8DB75BA8]
M02_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,238E2001F80
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC8E0A8020]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1178
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M03_L04
       mov       eax,edx
       shr       eax,3
       xchg      ax,ax
M03_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M03_L00
       test      dl,4
       je        short M03_L02
M03_L01:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
M03_L02:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M03_L03:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M03_L04:
       cmp       edx,4
       jae       short M03_L01
       mov       eax,80
       test      dl,1
       je        short M03_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M03_L05:
       test      dl,2
       mov       edx,eax
       je        short M03_L03
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       short M03_L03
; Total bytes of code 261
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M04_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M04_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M04_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFC8DEC4828]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M04_L05
       call      qword ptr [7FFC8DEC75E8]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M04_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFC8DAC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M04_L03
       jmp       near ptr M04_L09
M04_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L09
M04_L03:
       call      qword ptr [7FFC8DEC77F8]
       test      eax,eax
       je        near ptr M04_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFC8DF84450]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFC8DF84450]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFC8DF84480]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC8DEC76C0]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M04_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DF84318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M04_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DF84318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M04_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DF84318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DEC5A10]
       jmp       short M04_L09
M04_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DF84390]
       jmp       short M04_L09
M04_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M04_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFC8DAC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M04_L07
M04_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M04_L08
M04_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M04_L08:
       cmp       dword ptr [rbp-34],0
       je        short M04_L09
       call      qword ptr [7FFC8DECC978]
M04_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       xor       ecx,ecx
       mov       [rbp-8],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC8DEC59C8]; System.Text.Json.JsonSerializerOptions.get_IsReadOnly()
       test      eax,eax
       je        short M05_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC8DEC5278]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DF84360]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddTypeInfo(System.Type, Boolean)
       mov       [rbp-8],rax
       mov       ecx,[rbp+20]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M05_L01
       cmp       qword ptr [rbp-8],0
       je        short M05_L01
       mov       rcx,[rbp-8]
       call      qword ptr [7FFC8DEC66A0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.EnsureConfigured()
       jmp       short M05_L01
M05_L00:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M05_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFC8DEC5A28]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       [rbp-8],rax
M05_L01:
       cmp       qword ptr [rbp-8],0
       jne       short M05_L02
       lea       rcx,[rbp+28]
       call      qword ptr [7FFC8DD84720]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].GetValueOrDefault()
       test      eax,eax
       je        short M05_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC8DEC5488]; System.Text.Json.JsonSerializerOptions.get_TypeInfoResolver()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC8DECCF60]
M05_L02:
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 219
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M06_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M06_L02
M06_L01:
       mov       rax,rdx
       ret
M06_L02:
       test      rax,rax
       je        short M06_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L01
       test      rax,rax
       je        short M06_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L01
       test      rax,rax
       je        short M06_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L01
       test      rax,rax
       jne       short M06_L00
M06_L03:
       lea       rax,[7FFCEAE1B908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```

